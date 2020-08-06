using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DataStructures;


namespace MEMSTool
{
    public partial class FormMain : Form
    {
        // Timer used to continuous update form with engine data 
        Timer _updateTimer;

        // Mems Serial protocol Class
        SerialProtocol MemsProtocol = new SerialProtocol();

        // Mems data structure
        Mems_data MemsDataStructure = new Mems_data();

        // ECU connection status
        bool _connected = false;

        // file logging on/off
        bool _fileLogging = false;

        // global logFile Stream
        StreamWriter swLogFile;

        public FormMain() 
        {
            InitializeComponent();

            // populate COM port box
            COMPortChekedListBox.Items.AddRange(MemsProtocol.GetSerialPortNames() );

            // Create a timer
            _updateTimer = new Timer();

            // Tell the timer what to do when it tick
            _updateTimer.Tick += new EventHandler(UpdateTimer_Tick);

            // Set it to go off every one seconds - this should be like minimum and should be increased as rmp raise to ~1500ms at 5000 RMP
            _updateTimer.Interval = 350;

            // And start it        
            _updateTimer.Enabled = true;
        }

        void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Need to stop the timer, otherwise it will continue at it's set interval wether this process has finished or not.
            // Remove the stop if you want the event to fire every x seconds as opposed to x seconds after finish.
            //_updateTimer.Stop();

            //Method to run
            if (_connected)
            {
                string stringRawData1 = "";
                string stringRawData2 = "";

                // Run heartbeat
                MemsProtocol.Mems_heartbeat();

                // Get data from ECU
                MemsProtocol.Mems_read(ref MemsDataStructure, ref stringRawData1, ref stringRawData2);

                // Show raw data in GUI
                textBox_RawData.Text = stringRawData1 + "\r\n" + stringRawData2;

                if (_fileLogging) //Log raw data to file
                {
                    swLogFile.WriteLine(stringRawData2);
                    swLogFile.WriteLine(stringRawData1);
                    swLogFile.Flush();
                }
                                     
                // If connected enable ECU control/test options
                if (!groupBoxErrorCodes.Enabled) groupBoxErrorCodes.Enabled = true;
                if (!groupBoxEcuAdjustment.Enabled) groupBoxEcuAdjustment.Enabled = true;
                if (!groupBox_LogToFile.Enabled) groupBox_LogToFile.Enabled = true;
                if (!groupBox_IacControl.Enabled) groupBox_IacControl.Enabled = true;

                // I have read that the MEMS ECU send data slower and slower as engine speed increase, the following handle this
                if (MemsDataStructure.engine_rpm > 2000)
                {
                    _updateTimer.Stop();
                    _updateTimer.Interval = (int) (350 * MemsDataStructure.engine_rpm / 1200);
                    _updateTimer.Start();
                }
                else
                {
                    _updateTimer.Stop();
                    _updateTimer.Interval = 350;
                    _updateTimer.Start();
                }
            }
            else
            {
                if (groupBoxErrorCodes.Enabled) groupBoxErrorCodes.Enabled = false;
                if (groupBoxEcuAdjustment.Enabled) groupBoxEcuAdjustment.Enabled = false;
                if (groupBox_LogToFile.Enabled) groupBox_LogToFile.Enabled = false;
                if (groupBox_IacControl.Enabled) groupBox_IacControl.Enabled = false;
            }

            textBox_debug.Text = _updateTimer.Interval.ToString() + " update time in ms " + MemsDataStructure.idle_switch.ToString(); // Debug

            // update form data
            textBox_engine_rpm.Text = MemsDataStructure.engine_rpm.ToString();
            textBox_coolant_temp_c.Text = MemsDataStructure.coolant_temp_c.ToString();
            textBox_intake_air_temp_c.Text = MemsDataStructure.intake_air_temp_c.ToString();
            textBox_map_kpa.Text = MemsDataStructure.map_kpa.ToString();
            textBox_battery_voltage.Text = MemsDataStructure.battery_voltage.ToString();
            textBox_throttleAngle.Text = MemsDataStructure.throttleAngle.ToString();
            textBox_coil_time.Text = MemsDataStructure.coil_time.ToString();
            textBox_lambda_voltage_mv.Text = MemsDataStructure.lambda_voltage_mv.ToString();
            textBox_fuel_trim_longterm.Text = MemsDataStructure.fuel_trim_longterm.ToString();
            textBox_fuel_trim.Text = MemsDataStructure.fuel_trim.ToString();
            textBox_throttle_pot_voltage.Text = MemsDataStructure.throttle_pot_voltage.ToString();
            textBox_iac_position.Text = MemsDataStructure.iac_position.ToString();
            textBox_idle_error.Text = MemsDataStructure.idle_error.ToString();
            textBox_ignition_advance.Text = MemsDataStructure.ignition_advance.ToString();
            textBox_idle_base_pos.Text = MemsDataStructure.idle_base_pos.ToString();

            // Update radioButten's used as indicators
            radioButton_closed_loop.Checked = MemsDataStructure.closed_loop;
            radioButton_idle_switch.Checked = MemsDataStructure.idle_switch;
            radioButton_park_neutral_switch.Checked = MemsDataStructure.park_neutral_switch;
            radioButton_fault_codes_Coolant_temp_sensor.Checked = MemsDataStructure.fault_codes_Coolant_temp_sensor;
            radioButton_fault_codes_Inlet_air_temp_sensor.Checked = MemsDataStructure.fault_codes_Inlet_air_temp_sensor;
            radioButton_fault_codes_Fuel_pump_circuit.Checked = MemsDataStructure.fault_codes_Fuel_pump_circuit;
            radioButton_fault_codes_Throttle_pot_circuit.Checked = MemsDataStructure.fault_codes_Throttle_pot_circuit;

            // update Gauges
            aGaugeEngineRmp.Value = MemsDataStructure.engine_rpm / 100;
            aGauge_Colant_Temp_C.Value = MemsDataStructure.coolant_temp_c;
            aGauge_Intake_Air_temp_C.Value = MemsDataStructure.intake_air_temp_c;

            // Start the timer back up
            //_updateTimer.Start();
        }


        // Ensure only one COM port can be selected
        private void COMPortChekedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && COMPortChekedListBox.CheckedItems.Count > 0)
            {
                COMPortChekedListBox.ItemCheck -= COMPortChekedListBox_ItemCheck;
                COMPortChekedListBox.SetItemChecked(COMPortChekedListBox.CheckedIndices[0], false);
                COMPortChekedListBox.ItemCheck += COMPortChekedListBox_ItemCheck;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
            string[] comport = new string[1];
            byte[] initResponse = new byte[4];
            string responsStatus = "Please select a com port";

            if (COMPortChekedListBox.CheckedItems.Count == 1)
            {
                COMPortChekedListBox.CheckedItems.CopyTo(comport, 0);
                _connected = MemsProtocol.Mems_Connect(ref initResponse, comport[0]);

                // Check connection status and update status in GUI
                if (_connected)
                {
                    responsStatus = "Connected - ECU ID: " + initResponse[0].ToString("X2") + " " + initResponse[1].ToString("X2") + " " + initResponse[2].ToString("X2") + " " + initResponse[3].ToString("X2");
                }
                else
                {
                    responsStatus = "Connection failure - please check if ECU is coneected and ignition is on";
                }
            }
            else
            {
                // Update the COM port CheckedListBox
                COMPortChekedListBox.Items.Clear();
                COMPortChekedListBox.Items.AddRange(MemsProtocol.GetSerialPortNames());
            }

            labelConectionStatus.Text = responsStatus;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            // Ensure that updateTimer not use the port
            _connected = false;

            // Disconnect
            bool responsStatus = MemsProtocol.Mems_Disconnect();

            if (responsStatus)
            {
                labelConectionStatus.Text = "Disconnected";
            }
            else
            {
                labelConectionStatus.Text = "Disconnected - failed to send ECU disconnect command";
            }

            // Update the COM port CheckedListBox
            COMPortChekedListBox.Items.Clear();
            COMPortChekedListBox.Items.AddRange(MemsProtocol.GetSerialPortNames());

            // If connected disable ECU control/test options
            groupBoxErrorCodes.Enabled = false;
            groupBoxEcuAdjustment.Enabled = false;
        }

        private string memsCommand(Mems_command command)
        {
            byte result = memsCommandReturnByte(command);

            if (result != 0xFF)
            {
                return result.ToString();
            }
            else
            {
                return "error";
            }

        }

        private byte memsCommandReturnByte(Mems_command command)
        {
            Byte returDataByte = 0;
            bool status = false;

            _updateTimer.Stop(); //Always stop the update timer before executing a command

            status = MemsProtocol.Mems_Command(command, ref returDataByte);

            _updateTimer.Start(); //Always start the update timer after executing a command

            if ( status )
            {
                return returDataByte;
            }
            else
            {
                return 0xFF;
            }        
        }

        private void buttonClearErrors_Click(object sender, EventArgs e)
        {
            memsCommand(Mems_command.ClearFaults);
        }

        private void buttonDecrementFuelTrim_Click(object sender, EventArgs e)
        {
            textBoxFuelTrimAdj.Text = memsCommand(Mems_command.decrementFuelTrim);
        }

        private void buttonIncrementFuelTrim_Click(object sender, EventArgs e)
        {
            textBoxFuelTrimAdj.Text = memsCommand(Mems_command.incrementFuelTrim);
        }

        private void buttonDecrementIdleDecay_Click(object sender, EventArgs e)
        {
            textBoxIdleDecayAdj.Text = memsCommand(Mems_command.decrementIdleDecay);
        }

        private void buttonIncrementIdleDecay_Click(object sender, EventArgs e)
        {
            textBoxIdleDecayAdj.Text = memsCommand(Mems_command.incrementIdleDecay);
        }

        private void buttonDecrementIdleSpeed_Click(object sender, EventArgs e)
        {
            textBoxIdleSpeedAdj.Text = memsCommand(Mems_command.decrementIdleSpeed);
        }

        private void buttonIncrementIdleSpeed_Click(object sender, EventArgs e)
        {
            textBoxIdleSpeedAdj.Text = memsCommand(Mems_command.incrementIdleSpeed);
        }

        private void buttonDecrementIgnitionAdvanceOffset_Click(object sender, EventArgs e)
        {
            textBoxIgnitionAdvanceOffsetAdj.Text = memsCommand(Mems_command.decrementIgnitionAdvanceOffset); 
        }

        private void buttonIncrementIgnitionAdvanceOffset_Click(object sender, EventArgs e)
        {
            textBoxIgnitionAdvanceOffsetAdj.Text = memsCommand(Mems_command.incrementIgnitionAdvanceOffset);             
        }

        private void button_changeLogFile_Click(object sender, EventArgs e)
        {
            changeLogFíleFolderName();
        }

        private void button_StartStopLogging_Click(object sender, EventArgs e)
        {
            if (button_StartStopLogging.Text == "Start logging")
            { 
                if (textBox_LogFile.Text == "MemsLogFile.log")
                {
                    changeLogFíleFolderName();
                }
                else
                {
                    try
                    {
                        swLogFile = new StreamWriter(textBox_LogFile.Text, true, Encoding.ASCII);

                        swLogFile.WriteLine("Running command: read-raw");
                        swLogFile.WriteLine("ECU responded to D0 command with: 98 00 00 02");
                        swLogFile.WriteLine("");
                        swLogFile.Flush();

                        button_StartStopLogging.Text = "Stop Logging";

                        _fileLogging = true;

                    }
                    catch
                    {
                        textBox_LogFile.Text = "Error, please select another folder/name";
                        _fileLogging = false;
                    }
                }
            }
            else // Stop logging
            {
                _fileLogging = false;

                swLogFile.Close();

                button_StartStopLogging.Text = "Start logging";
            }
        }

        private void changeLogFíleFolderName()
        {

            SaveFileDialog SaveFileDialog_LogFile = new SaveFileDialog();

            SaveFileDialog_LogFile.FileName = "Please select folder and type filename";
            SaveFileDialog_LogFile.DefaultExt = "txt";
            SaveFileDialog_LogFile.Filter = "Text files (*.txt)|*.txt";
            SaveFileDialog_LogFile.CheckPathExists = true;

            if (SaveFileDialog_LogFile.ShowDialog() == DialogResult.OK)
            {
                textBox_LogFile.Text = SaveFileDialog_LogFile.FileName;
            }
        }

        private void button_GetIacPosition_Click(object sender, EventArgs e)
        {
            trackBar_IAC.Value = memsCommandReturnByte(Mems_command.GetIACPosition);
        }

        private void button_SetIacPosition_Click(object sender, EventArgs e)
        {
            _updateTimer.Stop(); //Always stop the update timer before executing a command

            // Try to move to the desired position, current no error handling defined
            MemsProtocol.Mems_move_iac((byte)trackBar_IAC.Value);

            // Update the trackBar
            trackBar_IAC.Value = memsCommandReturnByte(Mems_command.GetIACPosition);

            _updateTimer.Start(); //Always start the update timer after executing a command
        }

        private void button_ResetTrimToDefault_Click(object sender, EventArgs e)
        {
            memsCommand(Mems_command.ResetTrimToDefault);
        }
    }
}
