using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

    //public Byte equivalent to Byte or Byte(unsigned Byte).
    //int8_t equivalent to  Byte or SByte(signed Byte).
    //ushort equivalent to ushort (unsigned short).
    //int16_t equivalent to short (signed short).
    //uint32_t equivalent to uint (unsigned integer).
    //int32_t equivalent to int (signed integer).

    public class Mems_constants
    {
        public const byte IAC_MAXIMUM             = 0xB4;
        public const byte Mems_data_frame_7d_size = 32;
        public const byte Mems_data_frame_80_Size = 28;
    }

    /**
    * These commands are used to request data, clear fault codes. test actuators and ignition/fuel trim.
    */
    public enum Mems_command
    {
        ReqData7D = 0x7D,
        ReqData80 = 0x80,
        ClearFaults = 0xCC,
        Heartbeat = 0xF4,
        Disconnect = 0xF6,
        GetIACPosition = 0xFB,
        decrementFuelTrim = 0x7A,
        incrementFuelTrim = 0x79,
        decrementIdleDecay = 0x8A,
        incrementIdleDecay = 0x89,
        decrementIdleSpeed = 0x92,
        incrementIdleSpeed = 0x91,
        decrementIgnitionAdvanceOffset = 0x94,
        incrementIgnitionAdvanceOffset = 0x93,
        ResetTrimToDefault = 0xF0,
        ResetAll = 0xFA, // I have not had the guts to try this one
        FuelPumpOn = 0x11,
        FuelPumpOff = 0x01,
        PTCRelayOn = 0x12,
        PTCRelayOff = 0x02,
        ACRelayOn = 0x13,
        ACRelayOff = 0x03,
        PurgeValveOn = 0x18,
        PurgeValveOff = 0x08,
        O2HeaterOn = 0x19,
        O2HeaterOff = 0x09,
        BoostValveOn = 0x1B,
        BoostValveOff = 0x0B,
        Fan1On = 0x1D,
        Fan1Off = 0x0D,
        Fan2On = 0x1E,
        Fan2Off = 0x0E,
        TestInjectors = 0xF7,
        FireCoil = 0xF8,
        OpenIAC = 0xFD,
        CloseIAC = 0xFE
    };

    /**
    * Data sequence returned by the ECU in reply to the command 0x7D.
    */
    public class Mems_data_frame_7d
    {
        public Byte bytes_in_frame;
        public Byte b;
        public Byte throttleAngle;
        public Byte d;
        public Byte e;
        public Byte f;
        public Byte lambda_voltage;
        public Byte h;
        public Byte i;
        public Byte j;
        public Byte closed_loop;
        public Byte fuel_trim_longterm;
        public Byte fuel_trim;
        public Byte n;
        public Byte o;
        public Byte idle_base_pos;
        public Byte q;
        public Byte r;
        public Byte s;
        public Byte t;
        public Byte u;
        public Byte v;
        public Byte w;
        public Byte x;
        public Byte y;
        public Byte z;
        public Byte aa;
        public Byte bb;
        public Byte cc;
        public Byte dd;
        public Byte ee;
        public Byte ff;

        // For logging purpose
        public override string ToString()
        {
            return string.Format("7D: {0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2} {8:X2} {9:X2} {10:X2} {11:X2} {12:X2} {13:X2} {14:X2} {15:X2} {16:X2} {17:X2} {18:X2} {19:X2} {20:X2} {21:X2} {22:X2} {23:X2} {24:X2} {25:X2} {26:X2} {27:X2} {28:X2} {29:X2} {30:X2} {31:X2}",
                 bytes_in_frame, b, throttleAngle, d, e, f, lambda_voltage, h, i, j, closed_loop, fuel_trim_longterm, fuel_trim, n, o, idle_base_pos, q, r, s, t, u, v, w, x, y, z, aa, bb, cc, dd, ee, ff);
        }
    };

    /**
    * Data sequence returned by the ECU in reply to the command 0x80.
    */
    public class Mems_data_frame_80
    {
        public Byte bytes_in_frame;
        public Byte engine_rpm_hi;
        public Byte engine_rpm_lo;
        public Byte coolant_temp;
        public Byte ambient_temp;
        public Byte intake_air_temp;
        public Byte fuel_temp;
        public Byte map_kpa;
        public Byte battery_voltage;
        public Byte throttle_pot;
        public Byte idle_switch;
        public Byte b;
        public Byte park_neutral_switch;
        public Byte dtc0;
        public Byte dtc1;
        public Byte c;
        public Byte d;
        public Byte e;
        public Byte iac_position;
        public Byte idle_error_hi;
        public Byte idle_error_lo;
        public Byte ignition_advance_offset;
        public Byte ignition_advance;
        public Byte coil_time_hi;
        public Byte coil_time_lo;
        public Byte g;
        public Byte h;
        public Byte i;

        // For logging purpose
        public override string ToString()
        {
            return string.Format("80: {0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2} {8:X2} {9:X2} {10:X2} {11:X2} {12:X2} {13:X2} {14:X2} {15:X2} {16:X2} {17:X2} {18:X2} {19:X2} {20:X2} {21:X2} {22:X2} {23:X2} {24:X2} {25:X2} {26:X2} {27:X2}", 
                bytes_in_frame, engine_rpm_hi, engine_rpm_lo, coolant_temp, ambient_temp, intake_air_temp, fuel_temp, 
                map_kpa, battery_voltage, throttle_pot, idle_switch, b, park_neutral_switch, dtc0, dtc1, c, d, e, iac_position
                , idle_error_hi, idle_error_lo, ignition_advance_offset, ignition_advance, coil_time_hi, coil_time_lo, g, h, i);
        }
    };


    /**
    * Compact structure containing only the relevant data from the ECU.
    */
    public class Mems_data
    {
        public ushort engine_rpm;
        public sbyte  coolant_temp_c;
        public sbyte  ambient_temp_c;
        public sbyte  intake_air_temp_c;
        public sbyte  fuel_temp_c;
        public float  map_kpa;
        public float  battery_voltage;
        public Byte throttleAngle;
        public float  throttle_pot_voltage;
        public bool   idle_switch;
        public bool   park_neutral_switch;
        public bool fault_codes_Coolant_temp_sensor;
        public bool fault_codes_Inlet_air_temp_sensor;
        public bool fault_codes_Fuel_pump_circuit;
        public bool fault_codes_Throttle_pot_circuit;
        public bool closed_loop;
        public Byte   iac_position;
        public ushort idle_error;
        public float  ignition_advance;
        public float  coil_time;
        public ushort lambda_voltage_mv;
        public Byte   fuel_trim_longterm;
        public Byte   fuel_trim;
        public Byte   idle_base_pos;
    };
}
