using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using DataStructures;
using System.Threading;

namespace MEMSTool
{
    class SerialProtocol
    {
        static SerialPort _serialPort;

        // Can be used for debug purpose
        private void dprintf_err(string a, string b = "", string c = "") { }

        // Get list of available serial ports
        public string[] GetSerialPortNames() {
            
            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            string[] strPortsList = SerialPort.GetPortNames();
            Array.Sort(strPortsList);

            return strPortsList;
        }

        // Open Serial port
        private bool OpenSerialPort(string PortName)
        {
            bool status = false;

            if (!_serialPort.IsOpen)
            {
                try
                {
                    // Allow the user to set the appropriate properties.
                    _serialPort.PortName = PortName;
                    _serialPort.BaudRate = 9600;
                    _serialPort.Parity = Parity.None;
                    _serialPort.DataBits = 8;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.Handshake = Handshake.None;

                    // Set the read/write timeouts
                    _serialPort.ReadTimeout = 500;
                    _serialPort.WriteTimeout = 500;

                    _serialPort.Open();
                    status = true;
                }
                catch (IOException ex)
                {
                    dprintf_err(ex.ToString());
                    status = false;
                }
            }
            else
            {
                // Returner true hvis porten allerede er open
                status = true;
            }

            return status;
        }

        /**
        * Reads bytes from the serial device using an OS-specific call.
        * @param buffer Buffer into which data should be read
        * @param quantity Number of bytes to read
        * @return Number of bytes read from the device, or -1 if no bytes could be read
        */

        private short Mems_read_serial(ref Byte buffer, ushort quantity)
        {
            Byte[] bufferout = { buffer };

            short ret = Mems_read_serial(ref bufferout, quantity);

            buffer = bufferout[0];

            return ret;
        }
        private short Mems_read_serial(ref Byte[] buffer, ushort quantity)
        {
            short totalBytesRead = 0;
            short maxWaitCount = 50; // This is the max ammount of loops we wait for an ansver, 5 is approximate ½ secund
            short waitLoop = 0;

            if ( _serialPort.IsOpen ) // Check if port is open
            {
                do
                {
                    waitLoop++;

                    try
                    {
                        if (_serialPort.BytesToRead > 0)
                        {
                            buffer[totalBytesRead] = (byte)_serialPort.ReadByte(); //read a byte

                            totalBytesRead++;
                        }
                        else
                        {
                            Thread.Sleep(10); // Short delay before we try again
                        }
                    }
                    catch
                    {
                        break;
                    }

                } while ( (totalBytesRead < quantity) && (waitLoop < maxWaitCount) );
            }

            if (totalBytesRead < quantity)
            {
                dprintf_err("Mems_read_serial(): expected %d, got %d\n", quantity.ToString(), totalBytesRead.ToString());
            }

            return totalBytesRead;
        }

        /**
         * Writes a byte to the serial device using an OS-specific call
         * @return true is byte is successfull send
         */
        private bool Mems_write_serial(Byte data)
        {
            bool status = false;
            byte[] arrayData = { data };

            try
            {
                if ( _serialPort.IsOpen ) // Check if port is open
                {
                    _serialPort.Write(arrayData, 0,1); //read a byte
                }

                status = true;
            }
            catch
            {
                status = false;
            }

            return status;
        }

        /**
        * Sends an initialization/startup sequence to the ECU. Required to enable further communication.
        */
        public bool Mems_Connect(ref Byte[] d0_response_buffer, string PortName)
        {
            // Connect to the serial port
            bool portOpenstatus = OpenSerialPort(PortName);

            // Return statu and false if port not can be opened
            if (!portOpenstatus)
            {
                d0_response_buffer[0] = 0xFF;
                return false;
            }

            Byte command_a = 0xCA;
            Byte command_b = 0x75;
            Byte command_c = (Byte)Mems_command.Heartbeat;
            Byte command_d = 0xD0;
            Byte buffer = 0x00;

            if (!Mems_send_command(command_a))
            {
                dprintf_err("Mems_init_link(): Did not see %02X command echo\n", command_a.ToString());
                return false;
            }
            if (!Mems_send_command(command_b))
            {
                dprintf_err("Mems_init_link(): Did not see %02X command echo\n", command_b.ToString());
                return false;
            }
            if (!Mems_send_command(command_c))
            {
                dprintf_err("Mems_init_link(): Did not see %02X command echo\n", command_c.ToString());
                return false;
            }
            if (Mems_read_serial(ref buffer, 1) != 1)
            {
                dprintf_err("Mems_init_link(): Did not see null terminator for %02X command\n", command_c.ToString());
                return false;
            }
            if (!Mems_send_command(command_d))
            {
                dprintf_err("Mems_init_link(): Did not see %02X command echo\n", command_d.ToString());
                return false;
            }

            // Expect four more bytes after the echo of the D0 command byte.
            // Response is 99 00 03 03 for Mini SPi.
            if (Mems_read_serial(ref d0_response_buffer, 4) != 4)
            {
                dprintf_err("Mems_init_link(): Received fewer bytes than expected after echo of %02X command", command_d.ToString());
                return false;
            }

            return true;
        }

        // Send disconnect/com reset command to ECU and close serial port
        public bool Mems_Disconnect()
        {
            bool ret = false;

            // Send disconnect command to ECU
            ret = Mems_send_command((Byte)Mems_command.Disconnect);

            //Close COM port
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            return ret;
        }

        /**
         * Sends a single command byte to the ECU and waits for the same byte to be
         * echoed as a response. Note that if the ECU sends one or more bytes of
         * data in addition to the echoed command byte, Mems_read_serial() must also
         * be called to retrieve that data from the input buffer.
         */
        private bool Mems_send_command( Byte cmd)
        {
            bool result = false;
            Byte response = 0xFF;

            if (Mems_write_serial( cmd ) == true)
            {
                if (Mems_read_serial( ref response, 1) == 1)
                {
                    if (response == cmd)
                    {
                        result = true;
                    }
                    else
                    {
                        dprintf_err("Mems_send_command(): received one nonmatching byte (%02X) in response to command %02X\n", response.ToString(), cmd.ToString());
                    }
                }
                else
                {
                    dprintf_err("Mems_send_command(): did not receive echo of command %02X\n".ToString(), cmd.ToString());
                }
            }
            else
            {
                dprintf_err("Mems_send_command(): failed to send command %02X\n", cmd.ToString());
            }

            return result;
        }

 
        /**
         * Converts the temperature value used by the ECU degrees celtius.
         */
        private sbyte Temperature_value_to_degrees_c(Byte val)
        {
            int degrees_c = val - 55;
            return (sbyte)degrees_c;
        }

        /**
         * Sends a command to read a frame of data from the ECU, and returns the raw frame.
         */
        private bool Mems_read_raw(ref Mems_data_frame_80 frame80, ref Mems_data_frame_7d frame7d)
        {
            bool status = false;
            byte[] rawFrame7d = new byte[Mems_constants.Mems_data_frame_7d_size];
            byte[] rawFrame80 = new byte[Mems_constants.Mems_data_frame_80_Size];

            if (Mems_send_command((Byte)Mems_command.ReqData80))
            {
                if (Mems_read_serial( ref rawFrame80, (ushort)Mems_constants.Mems_data_frame_80_Size) == (ushort)Mems_constants.Mems_data_frame_80_Size)
                {

                        //Copy recived data to data structure
                        frame80.bytes_in_frame = rawFrame80[0];
                        frame80.engine_rpm_hi = rawFrame80[1];
                        frame80.engine_rpm_lo = rawFrame80[2];
                        frame80.coolant_temp = rawFrame80[3];
                        frame80.ambient_temp = rawFrame80[4];
                        frame80.intake_air_temp = rawFrame80[5];
                        frame80.fuel_temp = rawFrame80[6];
                        frame80.map_kpa = rawFrame80[7];
                        frame80.battery_voltage = rawFrame80[8];
                        frame80.throttle_pot = rawFrame80[9];
                        frame80.idle_switch = rawFrame80[10];
                        frame80.b = rawFrame80[11];
                        frame80.park_neutral_switch = rawFrame80[12];
                        frame80.dtc0 = rawFrame80[13];
                        frame80.dtc1 = rawFrame80[14];
                        frame80.c = rawFrame80[15];
                        frame80.d = rawFrame80[16];
                        frame80.e = rawFrame80[17];
                        frame80.iac_position = rawFrame80[18];
                        frame80.idle_error_hi = rawFrame80[19];
                        frame80.idle_error_lo = rawFrame80[20];
                        frame80.ignition_advance_offset = rawFrame80[21];
                        frame80.ignition_advance = rawFrame80[22];
                        frame80.coil_time_hi = rawFrame80[23];
                        frame80.coil_time_lo = rawFrame80[24];
                        frame80.g = rawFrame80[25];
                        frame80.h = rawFrame80[26];
                        frame80.i = rawFrame80[27];

                        status = true;
                }
                else
                {
                    dprintf_err("Mems_read_raw(): failed to read data frame in response to cmd 0x80\n");
                }
            }
            else
            {
                dprintf_err("Mems_read_raw(): failed to send read command 0x80\n");
            }

            if (status)
            {
                if (Mems_send_command( (byte)Mems_command.ReqData7D))
                {
                    if (Mems_read_serial(ref rawFrame7d, (ushort)Mems_constants.Mems_data_frame_7d_size) == (ushort)Mems_constants.Mems_data_frame_7d_size)
                    {
                        //Copy recived data to data structure                        
                        frame7d.bytes_in_frame = rawFrame7d[0];
                        frame7d.b = rawFrame7d[1];
                        frame7d.throttleAngle = rawFrame7d[2];
                        frame7d.d = rawFrame7d[3];
                        frame7d.e = rawFrame7d[4];
                        frame7d.f = rawFrame7d[5];
                        frame7d.lambda_voltage = rawFrame7d[6];
                        frame7d.h = rawFrame7d[7];
                        frame7d.i = rawFrame7d[8];
                        frame7d.j = rawFrame7d[9];
                        frame7d.closed_loop = rawFrame7d[10];
                        frame7d.fuel_trim_longterm = rawFrame7d[11];
                        frame7d.fuel_trim = rawFrame7d[12];
                        frame7d.n = rawFrame7d[13];
                        frame7d.o = rawFrame7d[14];
                        frame7d.idle_base_pos = rawFrame7d[15];
                        frame7d.q = rawFrame7d[16];
                        frame7d.r = rawFrame7d[17];
                        frame7d.s = rawFrame7d[18];
                        frame7d.t = rawFrame7d[19];
                        frame7d.u = rawFrame7d[20];
                        frame7d.v = rawFrame7d[21];
                        frame7d.w = rawFrame7d[22];
                        frame7d.x = rawFrame7d[23];
                        frame7d.y = rawFrame7d[24];
                        frame7d.z = rawFrame7d[25];
                        frame7d.aa = rawFrame7d[26];
                        frame7d.bb = rawFrame7d[27];
                        frame7d.cc = rawFrame7d[28];
                        frame7d.dd = rawFrame7d[29];
                        frame7d.ee = rawFrame7d[30];
                        frame7d.ff = rawFrame7d[31];

                        status = true;
                    }
                    else
                    {
                        dprintf_err("Mems_read_raw(): failed to read data frame in response to cmd 0x7D\n");
                        status = false;
                    }
                }
                else
                {
                    dprintf_err("Mems_read_raw(): failed to send read command 0x7D\n");
                    status = false;
                }
            }

            return status;
        }

        /**
        * Sends an command to read a frame of data from the ECU, and parses the returned frame.
        * Íf used for logging it can be used with two optional string references returning the raw data for command 0c7D and 0x80 as a string
        */

        public bool Mems_read(ref Mems_data data)
        {
            string strTemp1 = "";
            string strTemp2 = "";

            return Mems_read(ref data, ref strTemp1, ref strTemp2);
        }


        public bool Mems_read( ref Mems_data data, ref string strDataFrame7d, ref string strDataFrame80)
        {
            bool success = false;
            Mems_data_frame_80 dframe80 = new Mems_data_frame_80();
            Mems_data_frame_7d dframe7d = new Mems_data_frame_7d();

            if (Mems_read_raw( ref dframe80, ref dframe7d))
            {
                data.lambda_voltage_mv = (ushort)(dframe7d.lambda_voltage * 5);
                data.fuel_trim_longterm = dframe7d.fuel_trim_longterm;
                data.fuel_trim = dframe7d.fuel_trim;
                data.closed_loop = (dframe7d.closed_loop == 0) ? false : true;
                data.idle_base_pos = dframe7d.idle_base_pos;
                data.throttleAngle = dframe7d.throttleAngle;

                data.engine_rpm = (ushort)(dframe80.engine_rpm_hi << 8 | dframe80.engine_rpm_lo);
                data.coolant_temp_c = Temperature_value_to_degrees_c(dframe80.coolant_temp);
                data.ambient_temp_c = Temperature_value_to_degrees_c(dframe80.ambient_temp);
                data.intake_air_temp_c = Temperature_value_to_degrees_c(dframe80.intake_air_temp);
                data.fuel_temp_c = Temperature_value_to_degrees_c(dframe80.fuel_temp);
                data.map_kpa = dframe80.map_kpa;
                data.battery_voltage = (float)(dframe80.battery_voltage / 10.0);
                data.throttle_pot_voltage = (float)(dframe80.throttle_pot * 0.02);
                data.idle_switch = ((dframe80.idle_switch & 0x08) == 0) ? false : true;
                data.park_neutral_switch = (dframe80.park_neutral_switch == 0) ? false : true;
                data.iac_position = dframe80.iac_position;
                data.coil_time = (ushort)((dframe80.coil_time_hi << 8 | dframe80.coil_time_lo) * 0.002);
                data.idle_error = (ushort)(dframe80.idle_error_hi << 8 | dframe80.idle_error_lo);
                data.ignition_advance = (float)((dframe80.ignition_advance * 0.5) - 24.0);
                data.fault_codes_Coolant_temp_sensor = ((dframe80.dtc0 & 0x01) == 0) ? false : true;
                data.fault_codes_Inlet_air_temp_sensor = ((dframe80.dtc0 & 0x02) == 0) ? false : true;
                data.fault_codes_Fuel_pump_circuit = ((dframe80.dtc1 & 0x02) == 0) ? false : true;
                data.fault_codes_Throttle_pot_circuit = ((dframe80.dtc1 & 0x80) == 0) ? false : true;

                // Return the raw data as two strings
                strDataFrame7d = dframe7d.ToString();
                strDataFrame80 = dframe80.ToString();

                success = true;
            }

            return success;
        }

        /**
         * Reads the current idle air control motor position.
         */
        public bool Mems_read_iac_position( ref Byte position)
        {
            bool status = false;

            status = Mems_send_command( (Byte) Mems_command.GetIACPosition) &&
                         (Mems_read_serial( ref position, 1) == 1);
                
            return status;
        }

        /**
         * Repeatedly send command to open or close the idle air control valve until
         * it is in the desired position. The valve does not necessarily move one full
         * step per serial command, depending on the rate at which the commands are
         * issued.
         */
        public bool Mems_move_iac( Byte desired_pos)
        {
            bool status = false;
            ushort attempts = 0;
            Byte current_pos = 0;
            Mems_command cmd;

            // read the current IAC position, and only take action
            // if we're not already at the desired point
            if (Mems_read_iac_position( ref current_pos))
            {
                if ((desired_pos < current_pos) ||
                    ((desired_pos > current_pos) && (current_pos < (byte)Mems_constants.IAC_MAXIMUM)))
                {
                    cmd = (desired_pos > current_pos) ? Mems_command.OpenIAC : Mems_command.CloseIAC;

                    do
                    {
                        status = Mems_Command( cmd, ref current_pos);
                        attempts += 1;
                    } while (status && (current_pos != desired_pos) && (attempts < 300));
                }
            }

            status = (desired_pos == current_pos);

            return status;
        }

        /**
         * Sends a command, and returns a single byte of data. All commands are availiable so watchout
         */
        public bool Mems_Command(Mems_command cmd, ref Byte data)
        {
            bool status = false;
            Byte response = 0x00;

            if (Mems_send_command( (Byte) cmd ) &&
                (Mems_read_serial( ref response, 1) == 1))
            {
                data = response;

                status = true;
            }

            return status;
        }

        /**
         * Sends a simple heartbeat (ping) command to check connectivity
         */
        public bool Mems_heartbeat()
        {
            bool status = false;
            Byte response = 0xFF;

            // send the command and check for one additional byte after the
            // echoed command byte (should be 0x00)
            if (Mems_send_command( (Byte)Mems_command.Heartbeat) &&
                (Mems_read_serial( ref response, 1) == 1))
            {
                status = true;
            }

            return status;
        }
    }
}
