namespace MEMSTool
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonDisconnect;
            System.Windows.Forms.Button buttonClearErrors;
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.COMPortChekedListBox = new System.Windows.Forms.CheckedListBox();
            this.labelConectionStatus = new System.Windows.Forms.Label();
            this.labelStaticConnectionStatus = new System.Windows.Forms.Label();
            this.label_engine_rpm = new System.Windows.Forms.Label();
            this.label_coolant_temp_c = new System.Windows.Forms.Label();
            this.label_intake_air_temp_c = new System.Windows.Forms.Label();
            this.label_map_kpa = new System.Windows.Forms.Label();
            this.label_battery_voltage = new System.Windows.Forms.Label();
            this.label_throttleAngle = new System.Windows.Forms.Label();
            this.label_throttle_pot_voltage = new System.Windows.Forms.Label();
            this.label_iac_position = new System.Windows.Forms.Label();
            this.label_idle_error = new System.Windows.Forms.Label();
            this.label_ignition_advance = new System.Windows.Forms.Label();
            this.label_coil_time = new System.Windows.Forms.Label();
            this.label_lambda_voltage_mv = new System.Windows.Forms.Label();
            this.label_fuel_trim_longterm = new System.Windows.Forms.Label();
            this.label_fuel_trim = new System.Windows.Forms.Label();
            this.label_idle_base_pos = new System.Windows.Forms.Label();
            this.textBox_engine_rpm = new System.Windows.Forms.TextBox();
            this.textBox_coolant_temp_c = new System.Windows.Forms.TextBox();
            this.textBox_intake_air_temp_c = new System.Windows.Forms.TextBox();
            this.textBox_map_kpa = new System.Windows.Forms.TextBox();
            this.textBox_battery_voltage = new System.Windows.Forms.TextBox();
            this.textBox_throttleAngle = new System.Windows.Forms.TextBox();
            this.textBox_coil_time = new System.Windows.Forms.TextBox();
            this.textBox_lambda_voltage_mv = new System.Windows.Forms.TextBox();
            this.textBox_fuel_trim_longterm = new System.Windows.Forms.TextBox();
            this.textBox_fuel_trim = new System.Windows.Forms.TextBox();
            this.textBox_throttle_pot_voltage = new System.Windows.Forms.TextBox();
            this.textBox_iac_position = new System.Windows.Forms.TextBox();
            this.textBox_idle_error = new System.Windows.Forms.TextBox();
            this.textBox_ignition_advance = new System.Windows.Forms.TextBox();
            this.textBox_idle_base_pos = new System.Windows.Forms.TextBox();
            this.radioButton_fault_codes_Coolant_temp_sensor = new System.Windows.Forms.RadioButton();
            this.radioButton_fault_codes_Inlet_air_temp_sensor = new System.Windows.Forms.RadioButton();
            this.radioButton_fault_codes_Fuel_pump_circuit = new System.Windows.Forms.RadioButton();
            this.radioButton_fault_codes_Throttle_pot_circuit = new System.Windows.Forms.RadioButton();
            this.groupBoxErrorCodes = new System.Windows.Forms.GroupBox();
            this.buttonDecrementFuelTrim = new System.Windows.Forms.Button();
            this.buttonIncrementFuelTrim = new System.Windows.Forms.Button();
            this.buttonIncrementIdleDecay = new System.Windows.Forms.Button();
            this.buttonDecrementIdleDecay = new System.Windows.Forms.Button();
            this.buttonIncrementIdleSpeed = new System.Windows.Forms.Button();
            this.buttonDecrementIdleSpeed = new System.Windows.Forms.Button();
            this.buttonIncrementIgnitionAdvanceOffset = new System.Windows.Forms.Button();
            this.buttonDecrementIgnitionAdvanceOffset = new System.Windows.Forms.Button();
            this.groupBoxEcuAdjustment = new System.Windows.Forms.GroupBox();
            this.textBoxIgnitionAdvanceOffsetAdj = new System.Windows.Forms.TextBox();
            this.textBoxIdleSpeedAdj = new System.Windows.Forms.TextBox();
            this.textBoxIdleDecayAdj = new System.Windows.Forms.TextBox();
            this.textBoxFuelTrimAdj = new System.Windows.Forms.TextBox();
            this.radioButton_closed_loop = new System.Windows.Forms.RadioButton();
            this.radioButton_idle_switch = new System.Windows.Forms.RadioButton();
            this.radioButton_park_neutral_switch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RawData = new System.Windows.Forms.TextBox();
            this.textBox_debug = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_IAC = new System.Windows.Forms.TrackBar();
            this.saveFileDialog_LogFile = new System.Windows.Forms.SaveFileDialog();
            this.textBox_LogFile = new System.Windows.Forms.TextBox();
            this.button_changeLogFile = new System.Windows.Forms.Button();
            this.button_StartStopLogging = new System.Windows.Forms.Button();
            this.groupBox_LogToFile = new System.Windows.Forms.GroupBox();
            this.button_GetIacPosition = new System.Windows.Forms.Button();
            this.button_SetIacPosition = new System.Windows.Forms.Button();
            this.groupBox_IacControl = new System.Windows.Forms.GroupBox();
            this.button_ResetTrimToDefault = new System.Windows.Forms.Button();
            this.aGauge_Intake_Air_temp_C = new System.Windows.Forms.AGauge();
            this.aGauge_Colant_Temp_C = new System.Windows.Forms.AGauge();
            this.aGaugeEngineRmp = new System.Windows.Forms.AGauge();
            buttonDisconnect = new System.Windows.Forms.Button();
            buttonClearErrors = new System.Windows.Forms.Button();
            this.groupBoxErrorCodes.SuspendLayout();
            this.groupBoxEcuAdjustment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_IAC)).BeginInit();
            this.groupBox_LogToFile.SuspendLayout();
            this.groupBox_IacControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new System.Drawing.Point(142, 69);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new System.Drawing.Size(100, 26);
            buttonDisconnect.TabIndex = 3;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonClearErrors
            // 
            buttonClearErrors.Location = new System.Drawing.Point(55, 114);
            buttonClearErrors.Name = "buttonClearErrors";
            buttonClearErrors.Size = new System.Drawing.Size(133, 26);
            buttonClearErrors.TabIndex = 59;
            buttonClearErrors.Text = "Clear Error Codes";
            buttonClearErrors.UseVisualStyleBackColor = true;
            buttonClearErrors.Click += new System.EventHandler(this.buttonClearErrors_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(142, 31);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 26);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // COMPortChekedListBox
            // 
            this.COMPortChekedListBox.CheckOnClick = true;
            this.COMPortChekedListBox.Location = new System.Drawing.Point(12, 31);
            this.COMPortChekedListBox.Name = "COMPortChekedListBox";
            this.COMPortChekedListBox.Size = new System.Drawing.Size(111, 64);
            this.COMPortChekedListBox.TabIndex = 4;
            this.COMPortChekedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.COMPortChekedListBox_ItemCheck);
            // 
            // labelConectionStatus
            // 
            this.labelConectionStatus.AutoSize = true;
            this.labelConectionStatus.Location = new System.Drawing.Point(139, 9);
            this.labelConectionStatus.Name = "labelConectionStatus";
            this.labelConectionStatus.Size = new System.Drawing.Size(78, 13);
            this.labelConectionStatus.TabIndex = 7;
            this.labelConectionStatus.Text = "Not connected";
            // 
            // labelStaticConnectionStatus
            // 
            this.labelStaticConnectionStatus.AutoSize = true;
            this.labelStaticConnectionStatus.Location = new System.Drawing.Point(13, 8);
            this.labelStaticConnectionStatus.Name = "labelStaticConnectionStatus";
            this.labelStaticConnectionStatus.Size = new System.Drawing.Size(97, 13);
            this.labelStaticConnectionStatus.TabIndex = 8;
            this.labelStaticConnectionStatus.Text = "Connection Status:";
            // 
            // label_engine_rpm
            // 
            this.label_engine_rpm.AutoSize = true;
            this.label_engine_rpm.Location = new System.Drawing.Point(660, 296);
            this.label_engine_rpm.Name = "label_engine_rpm";
            this.label_engine_rpm.Size = new System.Drawing.Size(62, 13);
            this.label_engine_rpm.TabIndex = 10;
            this.label_engine_rpm.Text = "engine_rpm";
            // 
            // label_coolant_temp_c
            // 
            this.label_coolant_temp_c.AutoSize = true;
            this.label_coolant_temp_c.Location = new System.Drawing.Point(459, 296);
            this.label_coolant_temp_c.Name = "label_coolant_temp_c";
            this.label_coolant_temp_c.Size = new System.Drawing.Size(83, 13);
            this.label_coolant_temp_c.TabIndex = 11;
            this.label_coolant_temp_c.Text = "coolant_temp_c";
            // 
            // label_intake_air_temp_c
            // 
            this.label_intake_air_temp_c.AutoSize = true;
            this.label_intake_air_temp_c.Location = new System.Drawing.Point(838, 296);
            this.label_intake_air_temp_c.Name = "label_intake_air_temp_c";
            this.label_intake_air_temp_c.Size = new System.Drawing.Size(94, 13);
            this.label_intake_air_temp_c.TabIndex = 12;
            this.label_intake_air_temp_c.Text = "intake_air_temp_c";
            // 
            // label_map_kpa
            // 
            this.label_map_kpa.AutoSize = true;
            this.label_map_kpa.Location = new System.Drawing.Point(288, 461);
            this.label_map_kpa.Name = "label_map_kpa";
            this.label_map_kpa.Size = new System.Drawing.Size(51, 13);
            this.label_map_kpa.TabIndex = 16;
            this.label_map_kpa.Text = "map_kpa";
            // 
            // label_battery_voltage
            // 
            this.label_battery_voltage.AutoSize = true;
            this.label_battery_voltage.Location = new System.Drawing.Point(796, 461);
            this.label_battery_voltage.Name = "label_battery_voltage";
            this.label_battery_voltage.Size = new System.Drawing.Size(80, 13);
            this.label_battery_voltage.TabIndex = 15;
            this.label_battery_voltage.Text = "battery_voltage";
            // 
            // label_throttleAngle
            // 
            this.label_throttleAngle.AutoSize = true;
            this.label_throttleAngle.Location = new System.Drawing.Point(288, 484);
            this.label_throttleAngle.Name = "label_throttleAngle";
            this.label_throttleAngle.Size = new System.Drawing.Size(66, 13);
            this.label_throttleAngle.TabIndex = 14;
            this.label_throttleAngle.Text = "throttleAngle";
            // 
            // label_throttle_pot_voltage
            // 
            this.label_throttle_pot_voltage.AutoSize = true;
            this.label_throttle_pot_voltage.Location = new System.Drawing.Point(288, 507);
            this.label_throttle_pot_voltage.Name = "label_throttle_pot_voltage";
            this.label_throttle_pot_voltage.Size = new System.Drawing.Size(101, 13);
            this.label_throttle_pot_voltage.TabIndex = 25;
            this.label_throttle_pot_voltage.Text = "throttle_pot_voltage";
            // 
            // label_iac_position
            // 
            this.label_iac_position.AutoSize = true;
            this.label_iac_position.Location = new System.Drawing.Point(796, 484);
            this.label_iac_position.Name = "label_iac_position";
            this.label_iac_position.Size = new System.Drawing.Size(63, 13);
            this.label_iac_position.TabIndex = 24;
            this.label_iac_position.Text = "iac_position";
            // 
            // label_idle_error
            // 
            this.label_idle_error.AutoSize = true;
            this.label_idle_error.Location = new System.Drawing.Point(796, 507);
            this.label_idle_error.Name = "label_idle_error";
            this.label_idle_error.Size = new System.Drawing.Size(50, 13);
            this.label_idle_error.TabIndex = 23;
            this.label_idle_error.Text = "idle_error";
            // 
            // label_ignition_advance
            // 
            this.label_ignition_advance.AutoSize = true;
            this.label_ignition_advance.Location = new System.Drawing.Point(542, 530);
            this.label_ignition_advance.Name = "label_ignition_advance";
            this.label_ignition_advance.Size = new System.Drawing.Size(88, 13);
            this.label_ignition_advance.TabIndex = 22;
            this.label_ignition_advance.Text = "ignition_advance";
            // 
            // label_coil_time
            // 
            this.label_coil_time.AutoSize = true;
            this.label_coil_time.Location = new System.Drawing.Point(542, 507);
            this.label_coil_time.Name = "label_coil_time";
            this.label_coil_time.Size = new System.Drawing.Size(48, 13);
            this.label_coil_time.TabIndex = 21;
            this.label_coil_time.Text = "coil_time";
            // 
            // label_lambda_voltage_mv
            // 
            this.label_lambda_voltage_mv.AutoSize = true;
            this.label_lambda_voltage_mv.Location = new System.Drawing.Point(542, 484);
            this.label_lambda_voltage_mv.Name = "label_lambda_voltage_mv";
            this.label_lambda_voltage_mv.Size = new System.Drawing.Size(102, 13);
            this.label_lambda_voltage_mv.TabIndex = 20;
            this.label_lambda_voltage_mv.Text = "lambda_voltage_mv";
            // 
            // label_fuel_trim_longterm
            // 
            this.label_fuel_trim_longterm.AutoSize = true;
            this.label_fuel_trim_longterm.Location = new System.Drawing.Point(542, 461);
            this.label_fuel_trim_longterm.Name = "label_fuel_trim_longterm";
            this.label_fuel_trim_longterm.Size = new System.Drawing.Size(92, 13);
            this.label_fuel_trim_longterm.TabIndex = 19;
            this.label_fuel_trim_longterm.Text = "fuel_trim_longterm";
            // 
            // label_fuel_trim
            // 
            this.label_fuel_trim.AutoSize = true;
            this.label_fuel_trim.Location = new System.Drawing.Point(288, 530);
            this.label_fuel_trim.Name = "label_fuel_trim";
            this.label_fuel_trim.Size = new System.Drawing.Size(46, 13);
            this.label_fuel_trim.TabIndex = 18;
            this.label_fuel_trim.Text = "fuel_trim";
            // 
            // label_idle_base_pos
            // 
            this.label_idle_base_pos.AutoSize = true;
            this.label_idle_base_pos.Location = new System.Drawing.Point(796, 530);
            this.label_idle_base_pos.Name = "label_idle_base_pos";
            this.label_idle_base_pos.Size = new System.Drawing.Size(75, 13);
            this.label_idle_base_pos.TabIndex = 33;
            this.label_idle_base_pos.Text = "idle_base_pos";
            // 
            // textBox_engine_rpm
            // 
            this.textBox_engine_rpm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_engine_rpm.Location = new System.Drawing.Point(661, 415);
            this.textBox_engine_rpm.Name = "textBox_engine_rpm";
            this.textBox_engine_rpm.ReadOnly = true;
            this.textBox_engine_rpm.Size = new System.Drawing.Size(66, 20);
            this.textBox_engine_rpm.TabIndex = 34;
            // 
            // textBox_coolant_temp_c
            // 
            this.textBox_coolant_temp_c.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_coolant_temp_c.Location = new System.Drawing.Point(467, 415);
            this.textBox_coolant_temp_c.Name = "textBox_coolant_temp_c";
            this.textBox_coolant_temp_c.ReadOnly = true;
            this.textBox_coolant_temp_c.Size = new System.Drawing.Size(66, 20);
            this.textBox_coolant_temp_c.TabIndex = 35;
            // 
            // textBox_intake_air_temp_c
            // 
            this.textBox_intake_air_temp_c.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_intake_air_temp_c.Location = new System.Drawing.Point(852, 415);
            this.textBox_intake_air_temp_c.Name = "textBox_intake_air_temp_c";
            this.textBox_intake_air_temp_c.ReadOnly = true;
            this.textBox_intake_air_temp_c.Size = new System.Drawing.Size(66, 20);
            this.textBox_intake_air_temp_c.TabIndex = 36;
            // 
            // textBox_map_kpa
            // 
            this.textBox_map_kpa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_map_kpa.Location = new System.Drawing.Point(391, 458);
            this.textBox_map_kpa.Name = "textBox_map_kpa";
            this.textBox_map_kpa.ReadOnly = true;
            this.textBox_map_kpa.Size = new System.Drawing.Size(100, 20);
            this.textBox_map_kpa.TabIndex = 40;
            // 
            // textBox_battery_voltage
            // 
            this.textBox_battery_voltage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_battery_voltage.Location = new System.Drawing.Point(899, 458);
            this.textBox_battery_voltage.Name = "textBox_battery_voltage";
            this.textBox_battery_voltage.ReadOnly = true;
            this.textBox_battery_voltage.Size = new System.Drawing.Size(100, 20);
            this.textBox_battery_voltage.TabIndex = 39;
            // 
            // textBox_throttleAngle
            // 
            this.textBox_throttleAngle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_throttleAngle.Location = new System.Drawing.Point(391, 481);
            this.textBox_throttleAngle.Name = "textBox_throttleAngle";
            this.textBox_throttleAngle.ReadOnly = true;
            this.textBox_throttleAngle.Size = new System.Drawing.Size(100, 20);
            this.textBox_throttleAngle.TabIndex = 38;
            // 
            // textBox_coil_time
            // 
            this.textBox_coil_time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_coil_time.Location = new System.Drawing.Point(645, 504);
            this.textBox_coil_time.Name = "textBox_coil_time";
            this.textBox_coil_time.ReadOnly = true;
            this.textBox_coil_time.Size = new System.Drawing.Size(100, 20);
            this.textBox_coil_time.TabIndex = 45;
            // 
            // textBox_lambda_voltage_mv
            // 
            this.textBox_lambda_voltage_mv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_lambda_voltage_mv.Location = new System.Drawing.Point(645, 481);
            this.textBox_lambda_voltage_mv.Name = "textBox_lambda_voltage_mv";
            this.textBox_lambda_voltage_mv.ReadOnly = true;
            this.textBox_lambda_voltage_mv.Size = new System.Drawing.Size(100, 20);
            this.textBox_lambda_voltage_mv.TabIndex = 44;
            // 
            // textBox_fuel_trim_longterm
            // 
            this.textBox_fuel_trim_longterm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_fuel_trim_longterm.Location = new System.Drawing.Point(645, 458);
            this.textBox_fuel_trim_longterm.Name = "textBox_fuel_trim_longterm";
            this.textBox_fuel_trim_longterm.ReadOnly = true;
            this.textBox_fuel_trim_longterm.Size = new System.Drawing.Size(100, 20);
            this.textBox_fuel_trim_longterm.TabIndex = 43;
            // 
            // textBox_fuel_trim
            // 
            this.textBox_fuel_trim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_fuel_trim.Location = new System.Drawing.Point(391, 527);
            this.textBox_fuel_trim.Name = "textBox_fuel_trim";
            this.textBox_fuel_trim.ReadOnly = true;
            this.textBox_fuel_trim.Size = new System.Drawing.Size(100, 20);
            this.textBox_fuel_trim.TabIndex = 42;
            // 
            // textBox_throttle_pot_voltage
            // 
            this.textBox_throttle_pot_voltage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_throttle_pot_voltage.Location = new System.Drawing.Point(391, 504);
            this.textBox_throttle_pot_voltage.Name = "textBox_throttle_pot_voltage";
            this.textBox_throttle_pot_voltage.ReadOnly = true;
            this.textBox_throttle_pot_voltage.Size = new System.Drawing.Size(100, 20);
            this.textBox_throttle_pot_voltage.TabIndex = 49;
            // 
            // textBox_iac_position
            // 
            this.textBox_iac_position.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_iac_position.Location = new System.Drawing.Point(899, 481);
            this.textBox_iac_position.Name = "textBox_iac_position";
            this.textBox_iac_position.ReadOnly = true;
            this.textBox_iac_position.Size = new System.Drawing.Size(100, 20);
            this.textBox_iac_position.TabIndex = 48;
            // 
            // textBox_idle_error
            // 
            this.textBox_idle_error.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_idle_error.Location = new System.Drawing.Point(899, 504);
            this.textBox_idle_error.Name = "textBox_idle_error";
            this.textBox_idle_error.ReadOnly = true;
            this.textBox_idle_error.Size = new System.Drawing.Size(100, 20);
            this.textBox_idle_error.TabIndex = 47;
            // 
            // textBox_ignition_advance
            // 
            this.textBox_ignition_advance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_ignition_advance.Location = new System.Drawing.Point(645, 527);
            this.textBox_ignition_advance.Name = "textBox_ignition_advance";
            this.textBox_ignition_advance.ReadOnly = true;
            this.textBox_ignition_advance.Size = new System.Drawing.Size(100, 20);
            this.textBox_ignition_advance.TabIndex = 46;
            // 
            // textBox_idle_base_pos
            // 
            this.textBox_idle_base_pos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_idle_base_pos.Location = new System.Drawing.Point(899, 527);
            this.textBox_idle_base_pos.Name = "textBox_idle_base_pos";
            this.textBox_idle_base_pos.ReadOnly = true;
            this.textBox_idle_base_pos.Size = new System.Drawing.Size(100, 20);
            this.textBox_idle_base_pos.TabIndex = 50;
            // 
            // radioButton_fault_codes_Coolant_temp_sensor
            // 
            this.radioButton_fault_codes_Coolant_temp_sensor.AutoCheck = false;
            this.radioButton_fault_codes_Coolant_temp_sensor.AutoSize = true;
            this.radioButton_fault_codes_Coolant_temp_sensor.CausesValidation = false;
            this.radioButton_fault_codes_Coolant_temp_sensor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.radioButton_fault_codes_Coolant_temp_sensor.Location = new System.Drawing.Point(15, 22);
            this.radioButton_fault_codes_Coolant_temp_sensor.Name = "radioButton_fault_codes_Coolant_temp_sensor";
            this.radioButton_fault_codes_Coolant_temp_sensor.Size = new System.Drawing.Size(145, 17);
            this.radioButton_fault_codes_Coolant_temp_sensor.TabIndex = 53;
            this.radioButton_fault_codes_Coolant_temp_sensor.Text = "Coolant temp sensor error";
            this.radioButton_fault_codes_Coolant_temp_sensor.UseVisualStyleBackColor = true;
            // 
            // radioButton_fault_codes_Inlet_air_temp_sensor
            // 
            this.radioButton_fault_codes_Inlet_air_temp_sensor.AutoCheck = false;
            this.radioButton_fault_codes_Inlet_air_temp_sensor.AutoSize = true;
            this.radioButton_fault_codes_Inlet_air_temp_sensor.CausesValidation = false;
            this.radioButton_fault_codes_Inlet_air_temp_sensor.Location = new System.Drawing.Point(15, 91);
            this.radioButton_fault_codes_Inlet_air_temp_sensor.Name = "radioButton_fault_codes_Inlet_air_temp_sensor";
            this.radioButton_fault_codes_Inlet_air_temp_sensor.Size = new System.Drawing.Size(143, 17);
            this.radioButton_fault_codes_Inlet_air_temp_sensor.TabIndex = 57;
            this.radioButton_fault_codes_Inlet_air_temp_sensor.Text = "Inlet air temp sensor error";
            this.radioButton_fault_codes_Inlet_air_temp_sensor.UseVisualStyleBackColor = true;
            // 
            // radioButton_fault_codes_Fuel_pump_circuit
            // 
            this.radioButton_fault_codes_Fuel_pump_circuit.AutoCheck = false;
            this.radioButton_fault_codes_Fuel_pump_circuit.AutoSize = true;
            this.radioButton_fault_codes_Fuel_pump_circuit.CausesValidation = false;
            this.radioButton_fault_codes_Fuel_pump_circuit.Location = new System.Drawing.Point(15, 68);
            this.radioButton_fault_codes_Fuel_pump_circuit.Name = "radioButton_fault_codes_Fuel_pump_circuit";
            this.radioButton_fault_codes_Fuel_pump_circuit.Size = new System.Drawing.Size(129, 17);
            this.radioButton_fault_codes_Fuel_pump_circuit.TabIndex = 56;
            this.radioButton_fault_codes_Fuel_pump_circuit.Text = "Fuel pump circuit error";
            this.radioButton_fault_codes_Fuel_pump_circuit.UseVisualStyleBackColor = true;
            // 
            // radioButton_fault_codes_Throttle_pot_circuit
            // 
            this.radioButton_fault_codes_Throttle_pot_circuit.AutoCheck = false;
            this.radioButton_fault_codes_Throttle_pot_circuit.AutoSize = true;
            this.radioButton_fault_codes_Throttle_pot_circuit.CausesValidation = false;
            this.radioButton_fault_codes_Throttle_pot_circuit.Location = new System.Drawing.Point(15, 45);
            this.radioButton_fault_codes_Throttle_pot_circuit.Name = "radioButton_fault_codes_Throttle_pot_circuit";
            this.radioButton_fault_codes_Throttle_pot_circuit.Size = new System.Drawing.Size(134, 17);
            this.radioButton_fault_codes_Throttle_pot_circuit.TabIndex = 55;
            this.radioButton_fault_codes_Throttle_pot_circuit.Text = "Throttle pot circuit error";
            this.radioButton_fault_codes_Throttle_pot_circuit.UseVisualStyleBackColor = true;
            // 
            // groupBoxErrorCodes
            // 
            this.groupBoxErrorCodes.Controls.Add(buttonClearErrors);
            this.groupBoxErrorCodes.Controls.Add(this.radioButton_fault_codes_Coolant_temp_sensor);
            this.groupBoxErrorCodes.Controls.Add(this.radioButton_fault_codes_Inlet_air_temp_sensor);
            this.groupBoxErrorCodes.Controls.Add(this.radioButton_fault_codes_Throttle_pot_circuit);
            this.groupBoxErrorCodes.Controls.Add(this.radioButton_fault_codes_Fuel_pump_circuit);
            this.groupBoxErrorCodes.Enabled = false;
            this.groupBoxErrorCodes.Location = new System.Drawing.Point(3, 308);
            this.groupBoxErrorCodes.Name = "groupBoxErrorCodes";
            this.groupBoxErrorCodes.Size = new System.Drawing.Size(252, 151);
            this.groupBoxErrorCodes.TabIndex = 58;
            this.groupBoxErrorCodes.TabStop = false;
            this.groupBoxErrorCodes.Text = "Error Codes";
            // 
            // buttonDecrementFuelTrim
            // 
            this.buttonDecrementFuelTrim.Location = new System.Drawing.Point(15, 36);
            this.buttonDecrementFuelTrim.Name = "buttonDecrementFuelTrim";
            this.buttonDecrementFuelTrim.Size = new System.Drawing.Size(130, 26);
            this.buttonDecrementFuelTrim.TabIndex = 59;
            this.buttonDecrementFuelTrim.Text = "FuelTrim-";
            this.buttonDecrementFuelTrim.UseVisualStyleBackColor = true;
            this.buttonDecrementFuelTrim.Click += new System.EventHandler(this.buttonDecrementFuelTrim_Click);
            // 
            // buttonIncrementFuelTrim
            // 
            this.buttonIncrementFuelTrim.Location = new System.Drawing.Point(254, 36);
            this.buttonIncrementFuelTrim.Name = "buttonIncrementFuelTrim";
            this.buttonIncrementFuelTrim.Size = new System.Drawing.Size(133, 26);
            this.buttonIncrementFuelTrim.TabIndex = 60;
            this.buttonIncrementFuelTrim.Text = "FuelTrim+";
            this.buttonIncrementFuelTrim.UseVisualStyleBackColor = true;
            this.buttonIncrementFuelTrim.Click += new System.EventHandler(this.buttonIncrementFuelTrim_Click);
            // 
            // buttonIncrementIdleDecay
            // 
            this.buttonIncrementIdleDecay.Location = new System.Drawing.Point(254, 68);
            this.buttonIncrementIdleDecay.Name = "buttonIncrementIdleDecay";
            this.buttonIncrementIdleDecay.Size = new System.Drawing.Size(133, 26);
            this.buttonIncrementIdleDecay.TabIndex = 62;
            this.buttonIncrementIdleDecay.Text = "Idle Decay+";
            this.buttonIncrementIdleDecay.UseVisualStyleBackColor = true;
            this.buttonIncrementIdleDecay.Click += new System.EventHandler(this.buttonIncrementIdleDecay_Click);
            // 
            // buttonDecrementIdleDecay
            // 
            this.buttonDecrementIdleDecay.Location = new System.Drawing.Point(15, 68);
            this.buttonDecrementIdleDecay.Name = "buttonDecrementIdleDecay";
            this.buttonDecrementIdleDecay.Size = new System.Drawing.Size(130, 26);
            this.buttonDecrementIdleDecay.TabIndex = 61;
            this.buttonDecrementIdleDecay.Text = "Idle Decay-";
            this.buttonDecrementIdleDecay.UseVisualStyleBackColor = true;
            this.buttonDecrementIdleDecay.Click += new System.EventHandler(this.buttonDecrementIdleDecay_Click);
            // 
            // buttonIncrementIdleSpeed
            // 
            this.buttonIncrementIdleSpeed.Location = new System.Drawing.Point(254, 100);
            this.buttonIncrementIdleSpeed.Name = "buttonIncrementIdleSpeed";
            this.buttonIncrementIdleSpeed.Size = new System.Drawing.Size(133, 26);
            this.buttonIncrementIdleSpeed.TabIndex = 64;
            this.buttonIncrementIdleSpeed.Text = "Idle Speed+";
            this.buttonIncrementIdleSpeed.UseVisualStyleBackColor = true;
            this.buttonIncrementIdleSpeed.Click += new System.EventHandler(this.buttonIncrementIdleSpeed_Click);
            // 
            // buttonDecrementIdleSpeed
            // 
            this.buttonDecrementIdleSpeed.Location = new System.Drawing.Point(15, 100);
            this.buttonDecrementIdleSpeed.Name = "buttonDecrementIdleSpeed";
            this.buttonDecrementIdleSpeed.Size = new System.Drawing.Size(130, 26);
            this.buttonDecrementIdleSpeed.TabIndex = 63;
            this.buttonDecrementIdleSpeed.Text = "Idle Speed-";
            this.buttonDecrementIdleSpeed.UseVisualStyleBackColor = true;
            this.buttonDecrementIdleSpeed.Click += new System.EventHandler(this.buttonDecrementIdleSpeed_Click);
            // 
            // buttonIncrementIgnitionAdvanceOffset
            // 
            this.buttonIncrementIgnitionAdvanceOffset.Location = new System.Drawing.Point(254, 131);
            this.buttonIncrementIgnitionAdvanceOffset.Name = "buttonIncrementIgnitionAdvanceOffset";
            this.buttonIncrementIgnitionAdvanceOffset.Size = new System.Drawing.Size(133, 26);
            this.buttonIncrementIgnitionAdvanceOffset.TabIndex = 66;
            this.buttonIncrementIgnitionAdvanceOffset.Text = "Ignition Advance Offset+";
            this.buttonIncrementIgnitionAdvanceOffset.UseVisualStyleBackColor = true;
            this.buttonIncrementIgnitionAdvanceOffset.Click += new System.EventHandler(this.buttonIncrementIgnitionAdvanceOffset_Click);
            // 
            // buttonDecrementIgnitionAdvanceOffset
            // 
            this.buttonDecrementIgnitionAdvanceOffset.Location = new System.Drawing.Point(15, 132);
            this.buttonDecrementIgnitionAdvanceOffset.Name = "buttonDecrementIgnitionAdvanceOffset";
            this.buttonDecrementIgnitionAdvanceOffset.Size = new System.Drawing.Size(130, 26);
            this.buttonDecrementIgnitionAdvanceOffset.TabIndex = 65;
            this.buttonDecrementIgnitionAdvanceOffset.Text = "Ignition Advance Offset-";
            this.buttonDecrementIgnitionAdvanceOffset.UseVisualStyleBackColor = true;
            this.buttonDecrementIgnitionAdvanceOffset.Click += new System.EventHandler(this.buttonDecrementIgnitionAdvanceOffset_Click);
            // 
            // groupBoxEcuAdjustment
            // 
            this.groupBoxEcuAdjustment.Controls.Add(this.button_ResetTrimToDefault);
            this.groupBoxEcuAdjustment.Controls.Add(this.textBoxIgnitionAdvanceOffsetAdj);
            this.groupBoxEcuAdjustment.Controls.Add(this.textBoxIdleSpeedAdj);
            this.groupBoxEcuAdjustment.Controls.Add(this.textBoxIdleDecayAdj);
            this.groupBoxEcuAdjustment.Controls.Add(this.textBoxFuelTrimAdj);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonDecrementFuelTrim);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonIncrementIgnitionAdvanceOffset);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonIncrementFuelTrim);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonDecrementIgnitionAdvanceOffset);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonDecrementIdleDecay);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonIncrementIdleSpeed);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonIncrementIdleDecay);
            this.groupBoxEcuAdjustment.Controls.Add(this.buttonDecrementIdleSpeed);
            this.groupBoxEcuAdjustment.Enabled = false;
            this.groupBoxEcuAdjustment.Location = new System.Drawing.Point(601, 8);
            this.groupBoxEcuAdjustment.Name = "groupBoxEcuAdjustment";
            this.groupBoxEcuAdjustment.Size = new System.Drawing.Size(401, 199);
            this.groupBoxEcuAdjustment.TabIndex = 60;
            this.groupBoxEcuAdjustment.TabStop = false;
            this.groupBoxEcuAdjustment.Text = "ECU Adjustment";
            // 
            // textBoxIgnitionAdvanceOffsetAdj
            // 
            this.textBoxIgnitionAdvanceOffsetAdj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIgnitionAdvanceOffsetAdj.Location = new System.Drawing.Point(152, 135);
            this.textBoxIgnitionAdvanceOffsetAdj.Name = "textBoxIgnitionAdvanceOffsetAdj";
            this.textBoxIgnitionAdvanceOffsetAdj.ReadOnly = true;
            this.textBoxIgnitionAdvanceOffsetAdj.Size = new System.Drawing.Size(94, 20);
            this.textBoxIgnitionAdvanceOffsetAdj.TabIndex = 69;
            // 
            // textBoxIdleSpeedAdj
            // 
            this.textBoxIdleSpeedAdj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIdleSpeedAdj.Location = new System.Drawing.Point(152, 104);
            this.textBoxIdleSpeedAdj.Name = "textBoxIdleSpeedAdj";
            this.textBoxIdleSpeedAdj.ReadOnly = true;
            this.textBoxIdleSpeedAdj.Size = new System.Drawing.Size(94, 20);
            this.textBoxIdleSpeedAdj.TabIndex = 68;
            // 
            // textBoxIdleDecayAdj
            // 
            this.textBoxIdleDecayAdj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIdleDecayAdj.Location = new System.Drawing.Point(152, 72);
            this.textBoxIdleDecayAdj.Name = "textBoxIdleDecayAdj";
            this.textBoxIdleDecayAdj.ReadOnly = true;
            this.textBoxIdleDecayAdj.Size = new System.Drawing.Size(94, 20);
            this.textBoxIdleDecayAdj.TabIndex = 67;
            // 
            // textBoxFuelTrimAdj
            // 
            this.textBoxFuelTrimAdj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFuelTrimAdj.Location = new System.Drawing.Point(152, 40);
            this.textBoxFuelTrimAdj.Name = "textBoxFuelTrimAdj";
            this.textBoxFuelTrimAdj.ReadOnly = true;
            this.textBoxFuelTrimAdj.Size = new System.Drawing.Size(94, 20);
            this.textBoxFuelTrimAdj.TabIndex = 61;
            // 
            // radioButton_closed_loop
            // 
            this.radioButton_closed_loop.AutoCheck = false;
            this.radioButton_closed_loop.AutoSize = true;
            this.radioButton_closed_loop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_closed_loop.Location = new System.Drawing.Point(451, 261);
            this.radioButton_closed_loop.Name = "radioButton_closed_loop";
            this.radioButton_closed_loop.Size = new System.Drawing.Size(82, 17);
            this.radioButton_closed_loop.TabIndex = 51;
            this.radioButton_closed_loop.Text = "closed_loop";
            this.radioButton_closed_loop.UseVisualStyleBackColor = true;
            // 
            // radioButton_idle_switch
            // 
            this.radioButton_idle_switch.AutoCheck = false;
            this.radioButton_idle_switch.AutoSize = true;
            this.radioButton_idle_switch.CausesValidation = false;
            this.radioButton_idle_switch.Location = new System.Drawing.Point(451, 216);
            this.radioButton_idle_switch.Name = "radioButton_idle_switch";
            this.radioButton_idle_switch.Size = new System.Drawing.Size(77, 17);
            this.radioButton_idle_switch.TabIndex = 52;
            this.radioButton_idle_switch.Text = "idle_switch";
            this.radioButton_idle_switch.UseVisualStyleBackColor = true;
            // 
            // radioButton_park_neutral_switch
            // 
            this.radioButton_park_neutral_switch.AutoCheck = false;
            this.radioButton_park_neutral_switch.AutoSize = true;
            this.radioButton_park_neutral_switch.CausesValidation = false;
            this.radioButton_park_neutral_switch.Location = new System.Drawing.Point(451, 239);
            this.radioButton_park_neutral_switch.Name = "radioButton_park_neutral_switch";
            this.radioButton_park_neutral_switch.Size = new System.Drawing.Size(120, 17);
            this.radioButton_park_neutral_switch.TabIndex = 54;
            this.radioButton_park_neutral_switch.Text = "park_neutral_switch";
            this.radioButton_park_neutral_switch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "x100";
            // 
            // textBox_RawData
            // 
            this.textBox_RawData.Location = new System.Drawing.Point(391, 561);
            this.textBox_RawData.Multiline = true;
            this.textBox_RawData.Name = "textBox_RawData";
            this.textBox_RawData.Size = new System.Drawing.Size(608, 42);
            this.textBox_RawData.TabIndex = 63;
            // 
            // textBox_debug
            // 
            this.textBox_debug.Location = new System.Drawing.Point(411, 35);
            this.textBox_debug.Name = "textBox_debug";
            this.textBox_debug.Size = new System.Drawing.Size(169, 20);
            this.textBox_debug.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Raw ECU frames";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "App Debug Messages";
            // 
            // trackBar_IAC
            // 
            this.trackBar_IAC.Location = new System.Drawing.Point(2, 54);
            this.trackBar_IAC.Maximum = 180;
            this.trackBar_IAC.Name = "trackBar_IAC";
            this.trackBar_IAC.Size = new System.Drawing.Size(245, 45);
            this.trackBar_IAC.TabIndex = 69;
            // 
            // saveFileDialog_LogFile
            // 
            this.saveFileDialog_LogFile.DefaultExt = "log";
            this.saveFileDialog_LogFile.Filter = "\"Log files|*.log\"";
            this.saveFileDialog_LogFile.Title = "Select log file folder and name";
            // 
            // textBox_LogFile
            // 
            this.textBox_LogFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_LogFile.Location = new System.Drawing.Point(9, 57);
            this.textBox_LogFile.Name = "textBox_LogFile";
            this.textBox_LogFile.ReadOnly = true;
            this.textBox_LogFile.Size = new System.Drawing.Size(230, 20);
            this.textBox_LogFile.TabIndex = 70;
            this.textBox_LogFile.Text = "MemsLogFile.log";
            // 
            // button_changeLogFile
            // 
            this.button_changeLogFile.Location = new System.Drawing.Point(9, 19);
            this.button_changeLogFile.Name = "button_changeLogFile";
            this.button_changeLogFile.Size = new System.Drawing.Size(100, 26);
            this.button_changeLogFile.TabIndex = 71;
            this.button_changeLogFile.Text = "Set logfile name";
            this.button_changeLogFile.UseVisualStyleBackColor = true;
            this.button_changeLogFile.Click += new System.EventHandler(this.button_changeLogFile_Click);
            // 
            // button_StartStopLogging
            // 
            this.button_StartStopLogging.Location = new System.Drawing.Point(139, 19);
            this.button_StartStopLogging.Name = "button_StartStopLogging";
            this.button_StartStopLogging.Size = new System.Drawing.Size(100, 26);
            this.button_StartStopLogging.TabIndex = 72;
            this.button_StartStopLogging.Text = "Start logging";
            this.button_StartStopLogging.UseVisualStyleBackColor = true;
            this.button_StartStopLogging.Click += new System.EventHandler(this.button_StartStopLogging_Click);
            // 
            // groupBox_LogToFile
            // 
            this.groupBox_LogToFile.Controls.Add(this.button_StartStopLogging);
            this.groupBox_LogToFile.Controls.Add(this.button_changeLogFile);
            this.groupBox_LogToFile.Controls.Add(this.textBox_LogFile);
            this.groupBox_LogToFile.Location = new System.Drawing.Point(3, 101);
            this.groupBox_LogToFile.Name = "groupBox_LogToFile";
            this.groupBox_LogToFile.Size = new System.Drawing.Size(252, 89);
            this.groupBox_LogToFile.TabIndex = 73;
            this.groupBox_LogToFile.TabStop = false;
            this.groupBox_LogToFile.Text = "Log to file";
            // 
            // button_GetIacPosition
            // 
            this.button_GetIacPosition.Location = new System.Drawing.Point(9, 24);
            this.button_GetIacPosition.Name = "button_GetIacPosition";
            this.button_GetIacPosition.Size = new System.Drawing.Size(100, 26);
            this.button_GetIacPosition.TabIndex = 73;
            this.button_GetIacPosition.Text = "Get IAC position";
            this.button_GetIacPosition.UseVisualStyleBackColor = true;
            this.button_GetIacPosition.Click += new System.EventHandler(this.button_GetIacPosition_Click);
            // 
            // button_SetIacPosition
            // 
            this.button_SetIacPosition.Location = new System.Drawing.Point(139, 24);
            this.button_SetIacPosition.Name = "button_SetIacPosition";
            this.button_SetIacPosition.Size = new System.Drawing.Size(100, 26);
            this.button_SetIacPosition.TabIndex = 74;
            this.button_SetIacPosition.Text = "Set IAC position";
            this.button_SetIacPosition.UseVisualStyleBackColor = true;
            this.button_SetIacPosition.Click += new System.EventHandler(this.button_SetIacPosition_Click);
            // 
            // groupBox_IacControl
            // 
            this.groupBox_IacControl.Controls.Add(this.button_SetIacPosition);
            this.groupBox_IacControl.Controls.Add(this.trackBar_IAC);
            this.groupBox_IacControl.Controls.Add(this.button_GetIacPosition);
            this.groupBox_IacControl.Location = new System.Drawing.Point(3, 196);
            this.groupBox_IacControl.Name = "groupBox_IacControl";
            this.groupBox_IacControl.Size = new System.Drawing.Size(252, 105);
            this.groupBox_IacControl.TabIndex = 75;
            this.groupBox_IacControl.TabStop = false;
            this.groupBox_IacControl.Text = "IAC control";
            // 
            // button_ResetTrimToDefault
            // 
            this.button_ResetTrimToDefault.Enabled = false;
            this.button_ResetTrimToDefault.Location = new System.Drawing.Point(135, 164);
            this.button_ResetTrimToDefault.Name = "button_ResetTrimToDefault";
            this.button_ResetTrimToDefault.Size = new System.Drawing.Size(130, 26);
            this.button_ResetTrimToDefault.TabIndex = 70;
            this.button_ResetTrimToDefault.Text = "Reset trim to default";
            this.button_ResetTrimToDefault.UseVisualStyleBackColor = true;
            this.button_ResetTrimToDefault.Click += new System.EventHandler(this.button_ResetTrimToDefault_Click);
            // 
            // aGauge_Intake_Air_temp_C
            // 
            this.aGauge_Intake_Air_temp_C.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_Intake_Air_temp_C.BaseArcRadius = 40;
            this.aGauge_Intake_Air_temp_C.BaseArcStart = 135;
            this.aGauge_Intake_Air_temp_C.BaseArcSweep = 270;
            this.aGauge_Intake_Air_temp_C.BaseArcWidth = 2;
            this.aGauge_Intake_Air_temp_C.Center = new System.Drawing.Point(55, 55);
            this.aGauge_Intake_Air_temp_C.GaugeAutoSize = false;
            aGaugeRange1.Color = System.Drawing.Color.Empty;
            aGaugeRange1.EndValue = 0F;
            aGaugeRange1.InnerRadius = 70;
            aGaugeRange1.InRange = false;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            this.aGauge_Intake_Air_temp_C.GaugeRanges.Add(aGaugeRange1);
            this.aGauge_Intake_Air_temp_C.Location = new System.Drawing.Point(828, 312);
            this.aGauge_Intake_Air_temp_C.MaxValue = 60F;
            this.aGauge_Intake_Air_temp_C.MinValue = -20F;
            this.aGauge_Intake_Air_temp_C.Name = "aGauge_Intake_Air_temp_C";
            this.aGauge_Intake_Air_temp_C.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge_Intake_Air_temp_C.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_Intake_Air_temp_C.NeedleRadius = 40;
            this.aGauge_Intake_Air_temp_C.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.aGauge_Intake_Air_temp_C.NeedleWidth = 3;
            this.aGauge_Intake_Air_temp_C.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge_Intake_Air_temp_C.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_Intake_Air_temp_C.ScaleLinesInterInnerRadius = 35;
            this.aGauge_Intake_Air_temp_C.ScaleLinesInterOuterRadius = 40;
            this.aGauge_Intake_Air_temp_C.ScaleLinesInterWidth = 1;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMajorInnerRadius = 32;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMajorOuterRadius = 40;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMajorStepValue = 20F;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMajorWidth = 2;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMinorInnerRadius = 37;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMinorOuterRadius = 40;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMinorTicks = 9;
            this.aGauge_Intake_Air_temp_C.ScaleLinesMinorWidth = 1;
            this.aGauge_Intake_Air_temp_C.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_Intake_Air_temp_C.ScaleNumbersFormat = null;
            this.aGauge_Intake_Air_temp_C.ScaleNumbersRadius = 50;
            this.aGauge_Intake_Air_temp_C.ScaleNumbersRotation = 0;
            this.aGauge_Intake_Air_temp_C.ScaleNumbersStartScaleLine = 0;
            this.aGauge_Intake_Air_temp_C.ScaleNumbersStepScaleLines = 1;
            this.aGauge_Intake_Air_temp_C.Size = new System.Drawing.Size(115, 100);
            this.aGauge_Intake_Air_temp_C.TabIndex = 68;
            this.aGauge_Intake_Air_temp_C.Text = "Intake Air Temp";
            this.aGauge_Intake_Air_temp_C.Value = 0F;
            // 
            // aGauge_Colant_Temp_C
            // 
            this.aGauge_Colant_Temp_C.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_Colant_Temp_C.BaseArcRadius = 40;
            this.aGauge_Colant_Temp_C.BaseArcStart = 135;
            this.aGauge_Colant_Temp_C.BaseArcSweep = 270;
            this.aGauge_Colant_Temp_C.BaseArcWidth = 2;
            this.aGauge_Colant_Temp_C.Center = new System.Drawing.Point(55, 55);
            this.aGauge_Colant_Temp_C.GaugeAutoSize = false;
            aGaugeRange2.Color = System.Drawing.Color.Red;
            aGaugeRange2.EndValue = 120F;
            aGaugeRange2.InnerRadius = 32;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange1";
            aGaugeRange2.OuterRadius = 40;
            aGaugeRange2.StartValue = 95F;
            aGaugeRange3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            aGaugeRange3.EndValue = 95F;
            aGaugeRange3.InnerRadius = 32;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange2";
            aGaugeRange3.OuterRadius = 40;
            aGaugeRange3.StartValue = 80F;
            this.aGauge_Colant_Temp_C.GaugeRanges.Add(aGaugeRange2);
            this.aGauge_Colant_Temp_C.GaugeRanges.Add(aGaugeRange3);
            this.aGauge_Colant_Temp_C.Location = new System.Drawing.Point(443, 312);
            this.aGauge_Colant_Temp_C.MaxValue = 120F;
            this.aGauge_Colant_Temp_C.MinValue = -20F;
            this.aGauge_Colant_Temp_C.Name = "aGauge_Colant_Temp_C";
            this.aGauge_Colant_Temp_C.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGauge_Colant_Temp_C.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGauge_Colant_Temp_C.NeedleRadius = 40;
            this.aGauge_Colant_Temp_C.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.aGauge_Colant_Temp_C.NeedleWidth = 3;
            this.aGauge_Colant_Temp_C.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge_Colant_Temp_C.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_Colant_Temp_C.ScaleLinesInterInnerRadius = 35;
            this.aGauge_Colant_Temp_C.ScaleLinesInterOuterRadius = 40;
            this.aGauge_Colant_Temp_C.ScaleLinesInterWidth = 1;
            this.aGauge_Colant_Temp_C.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_Colant_Temp_C.ScaleLinesMajorInnerRadius = 32;
            this.aGauge_Colant_Temp_C.ScaleLinesMajorOuterRadius = 40;
            this.aGauge_Colant_Temp_C.ScaleLinesMajorStepValue = 20F;
            this.aGauge_Colant_Temp_C.ScaleLinesMajorWidth = 2;
            this.aGauge_Colant_Temp_C.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGauge_Colant_Temp_C.ScaleLinesMinorInnerRadius = 37;
            this.aGauge_Colant_Temp_C.ScaleLinesMinorOuterRadius = 40;
            this.aGauge_Colant_Temp_C.ScaleLinesMinorTicks = 9;
            this.aGauge_Colant_Temp_C.ScaleLinesMinorWidth = 1;
            this.aGauge_Colant_Temp_C.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_Colant_Temp_C.ScaleNumbersFormat = null;
            this.aGauge_Colant_Temp_C.ScaleNumbersRadius = 50;
            this.aGauge_Colant_Temp_C.ScaleNumbersRotation = 0;
            this.aGauge_Colant_Temp_C.ScaleNumbersStartScaleLine = 0;
            this.aGauge_Colant_Temp_C.ScaleNumbersStepScaleLines = 1;
            this.aGauge_Colant_Temp_C.Size = new System.Drawing.Size(115, 100);
            this.aGauge_Colant_Temp_C.TabIndex = 67;
            this.aGauge_Colant_Temp_C.Text = "Engine Temp";
            this.aGauge_Colant_Temp_C.Value = 0F;
            // 
            // aGaugeEngineRmp
            // 
            this.aGaugeEngineRmp.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeEngineRmp.BaseArcRadius = 80;
            this.aGaugeEngineRmp.BaseArcStart = 135;
            this.aGaugeEngineRmp.BaseArcSweep = 270;
            this.aGaugeEngineRmp.BaseArcWidth = 2;
            this.aGaugeEngineRmp.GaugeAutoSize = false;
            aGaugeRange4.Color = System.Drawing.Color.Red;
            aGaugeRange4.EndValue = 70F;
            aGaugeRange4.InnerRadius = 70;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "GaugeRange1";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 60F;
            this.aGaugeEngineRmp.GaugeRanges.Add(aGaugeRange4);
            this.aGaugeEngineRmp.Location = new System.Drawing.Point(592, 243);
            this.aGaugeEngineRmp.MaxValue = 70F;
            this.aGaugeEngineRmp.MinValue = 0F;
            this.aGaugeEngineRmp.Name = "aGaugeEngineRmp";
            this.aGaugeEngineRmp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Yellow;
            this.aGaugeEngineRmp.NeedleColor2 = System.Drawing.Color.Gray;
            this.aGaugeEngineRmp.NeedleRadius = 80;
            this.aGaugeEngineRmp.NeedleType = System.Windows.Forms.NeedleType.Simple;
            this.aGaugeEngineRmp.NeedleWidth = 3;
            this.aGaugeEngineRmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGaugeEngineRmp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeEngineRmp.ScaleLinesInterInnerRadius = 73;
            this.aGaugeEngineRmp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeEngineRmp.ScaleLinesInterWidth = 1;
            this.aGaugeEngineRmp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeEngineRmp.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeEngineRmp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeEngineRmp.ScaleLinesMajorStepValue = 10F;
            this.aGaugeEngineRmp.ScaleLinesMajorWidth = 2;
            this.aGaugeEngineRmp.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGaugeEngineRmp.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeEngineRmp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeEngineRmp.ScaleLinesMinorTicks = 9;
            this.aGaugeEngineRmp.ScaleLinesMinorWidth = 1;
            this.aGaugeEngineRmp.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeEngineRmp.ScaleNumbersFormat = null;
            this.aGaugeEngineRmp.ScaleNumbersRadius = 95;
            this.aGaugeEngineRmp.ScaleNumbersRotation = 0;
            this.aGaugeEngineRmp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeEngineRmp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeEngineRmp.Size = new System.Drawing.Size(205, 180);
            this.aGaugeEngineRmp.TabIndex = 61;
            this.aGaugeEngineRmp.Text = "RMP";
            this.aGaugeEngineRmp.Value = 0F;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 615);
            this.Controls.Add(this.groupBox_IacControl);
            this.Controls.Add(this.aGauge_Intake_Air_temp_C);
            this.Controls.Add(this.aGauge_Colant_Temp_C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_debug);
            this.Controls.Add(this.textBox_RawData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_engine_rpm);
            this.Controls.Add(this.label_engine_rpm);
            this.Controls.Add(this.aGaugeEngineRmp);
            this.Controls.Add(this.groupBoxEcuAdjustment);
            this.Controls.Add(this.groupBoxErrorCodes);
            this.Controls.Add(this.radioButton_park_neutral_switch);
            this.Controls.Add(this.radioButton_idle_switch);
            this.Controls.Add(this.radioButton_closed_loop);
            this.Controls.Add(this.textBox_idle_base_pos);
            this.Controls.Add(this.textBox_throttle_pot_voltage);
            this.Controls.Add(this.textBox_iac_position);
            this.Controls.Add(this.textBox_idle_error);
            this.Controls.Add(this.textBox_ignition_advance);
            this.Controls.Add(this.textBox_coil_time);
            this.Controls.Add(this.textBox_lambda_voltage_mv);
            this.Controls.Add(this.textBox_fuel_trim_longterm);
            this.Controls.Add(this.textBox_fuel_trim);
            this.Controls.Add(this.textBox_map_kpa);
            this.Controls.Add(this.textBox_battery_voltage);
            this.Controls.Add(this.textBox_throttleAngle);
            this.Controls.Add(this.textBox_intake_air_temp_c);
            this.Controls.Add(this.textBox_coolant_temp_c);
            this.Controls.Add(this.label_idle_base_pos);
            this.Controls.Add(this.label_throttle_pot_voltage);
            this.Controls.Add(this.label_iac_position);
            this.Controls.Add(this.label_idle_error);
            this.Controls.Add(this.label_ignition_advance);
            this.Controls.Add(this.label_coil_time);
            this.Controls.Add(this.label_lambda_voltage_mv);
            this.Controls.Add(this.label_fuel_trim_longterm);
            this.Controls.Add(this.label_fuel_trim);
            this.Controls.Add(this.label_map_kpa);
            this.Controls.Add(this.label_battery_voltage);
            this.Controls.Add(this.label_throttleAngle);
            this.Controls.Add(this.label_intake_air_temp_c);
            this.Controls.Add(this.label_coolant_temp_c);
            this.Controls.Add(this.labelStaticConnectionStatus);
            this.Controls.Add(this.labelConectionStatus);
            this.Controls.Add(this.COMPortChekedListBox);
            this.Controls.Add(buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox_LogToFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = " ";
            this.groupBoxErrorCodes.ResumeLayout(false);
            this.groupBoxErrorCodes.PerformLayout();
            this.groupBoxEcuAdjustment.ResumeLayout(false);
            this.groupBoxEcuAdjustment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_IAC)).EndInit();
            this.groupBox_LogToFile.ResumeLayout(false);
            this.groupBox_LogToFile.PerformLayout();
            this.groupBox_IacControl.ResumeLayout(false);
            this.groupBox_IacControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.CheckedListBox COMPortChekedListBox;
        private System.Windows.Forms.Label labelConectionStatus;
        private System.Windows.Forms.Label labelStaticConnectionStatus;
        private System.Windows.Forms.Label label_engine_rpm;
        private System.Windows.Forms.Label label_coolant_temp_c;
        private System.Windows.Forms.Label label_intake_air_temp_c;
        private System.Windows.Forms.Label label_map_kpa;
        private System.Windows.Forms.Label label_battery_voltage;
        private System.Windows.Forms.Label label_throttleAngle;
        private System.Windows.Forms.Label label_throttle_pot_voltage;
        private System.Windows.Forms.Label label_iac_position;
        private System.Windows.Forms.Label label_idle_error;
        private System.Windows.Forms.Label label_ignition_advance;
        private System.Windows.Forms.Label label_coil_time;
        private System.Windows.Forms.Label label_lambda_voltage_mv;
        private System.Windows.Forms.Label label_fuel_trim_longterm;
        private System.Windows.Forms.Label label_fuel_trim;
        private System.Windows.Forms.Label label_idle_base_pos;
        private System.Windows.Forms.TextBox textBox_engine_rpm;
        private System.Windows.Forms.TextBox textBox_coolant_temp_c;
        private System.Windows.Forms.TextBox textBox_intake_air_temp_c;
        private System.Windows.Forms.TextBox textBox_map_kpa;
        private System.Windows.Forms.TextBox textBox_battery_voltage;
        private System.Windows.Forms.TextBox textBox_throttleAngle;
        private System.Windows.Forms.TextBox textBox_coil_time;
        private System.Windows.Forms.TextBox textBox_lambda_voltage_mv;
        private System.Windows.Forms.TextBox textBox_fuel_trim_longterm;
        private System.Windows.Forms.TextBox textBox_fuel_trim;
        private System.Windows.Forms.TextBox textBox_throttle_pot_voltage;
        private System.Windows.Forms.TextBox textBox_iac_position;
        private System.Windows.Forms.TextBox textBox_idle_error;
        private System.Windows.Forms.TextBox textBox_ignition_advance;
        private System.Windows.Forms.TextBox textBox_idle_base_pos;
        private System.Windows.Forms.RadioButton radioButton_fault_codes_Coolant_temp_sensor;
        private System.Windows.Forms.RadioButton radioButton_fault_codes_Inlet_air_temp_sensor;
        private System.Windows.Forms.RadioButton radioButton_fault_codes_Fuel_pump_circuit;
        private System.Windows.Forms.RadioButton radioButton_fault_codes_Throttle_pot_circuit;
        private System.Windows.Forms.GroupBox groupBoxErrorCodes;
        private System.Windows.Forms.Button buttonDecrementFuelTrim;
        private System.Windows.Forms.Button buttonIncrementFuelTrim;
        private System.Windows.Forms.Button buttonIncrementIdleDecay;
        private System.Windows.Forms.Button buttonDecrementIdleDecay;
        private System.Windows.Forms.Button buttonIncrementIdleSpeed;
        private System.Windows.Forms.Button buttonDecrementIdleSpeed;
        private System.Windows.Forms.Button buttonIncrementIgnitionAdvanceOffset;
        private System.Windows.Forms.Button buttonDecrementIgnitionAdvanceOffset;
        private System.Windows.Forms.GroupBox groupBoxEcuAdjustment;
        private System.Windows.Forms.TextBox textBoxIgnitionAdvanceOffsetAdj;
        private System.Windows.Forms.TextBox textBoxIdleSpeedAdj;
        private System.Windows.Forms.TextBox textBoxIdleDecayAdj;
        private System.Windows.Forms.TextBox textBoxFuelTrimAdj;
        private System.Windows.Forms.RadioButton radioButton_closed_loop;
        private System.Windows.Forms.RadioButton radioButton_idle_switch;
        private System.Windows.Forms.RadioButton radioButton_park_neutral_switch;
        private System.Windows.Forms.AGauge aGaugeEngineRmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_RawData;
        private System.Windows.Forms.TextBox textBox_debug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.AGauge aGauge_Colant_Temp_C;
        private System.Windows.Forms.AGauge aGauge_Intake_Air_temp_C;
        private System.Windows.Forms.TrackBar trackBar_IAC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_LogFile;
        private System.Windows.Forms.TextBox textBox_LogFile;
        private System.Windows.Forms.Button button_changeLogFile;
        private System.Windows.Forms.Button button_StartStopLogging;
        private System.Windows.Forms.GroupBox groupBox_LogToFile;
        private System.Windows.Forms.Button button_GetIacPosition;
        private System.Windows.Forms.Button button_SetIacPosition;
        private System.Windows.Forms.GroupBox groupBox_IacControl;
        private System.Windows.Forms.Button button_ResetTrimToDefault;
    }
}

