namespace Keithly_2182
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_timeout = new System.Windows.Forms.Label();
            this.textBox_timeout = new System.Windows.Forms.TextBox();
            this.textBox_counts_measurements = new System.Windows.Forms.TextBox();
            this.label_counts_measurements = new System.Windows.Forms.Label();
            this.label_elapsed_time = new System.Windows.Forms.Label();
            this.label_measure_rez = new System.Windows.Forms.Label();
            this.label_measure_counts = new System.Windows.Forms.Label();
            this.comboBox_units = new System.Windows.Forms.ComboBox();
            this.comboBox_range = new System.Windows.Forms.ComboBox();
            this.groupBox_measure_settings = new System.Windows.Forms.GroupBox();
            this.textBox_scale_points = new System.Windows.Forms.TextBox();
            this.label_chart_scale_points = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.textBox_round = new System.Windows.Forms.TextBox();
            this.label_stat_counts = new System.Windows.Forms.Label();
            this.textBox_stat_counts = new System.Windows.Forms.TextBox();
            this.label_remove_points = new System.Windows.Forms.Label();
            this.textBox_remove_points = new System.Windows.Forms.TextBox();
            this.checkBox_chart = new System.Windows.Forms.CheckBox();
            this.checkBox_save_log = new System.Windows.Forms.CheckBox();
            this.label_units = new System.Windows.Forms.Label();
            this.label_range = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_file_name = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_save_file = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_voltmeter_settings = new System.Windows.Forms.GroupBox();
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.comboBox_d_filter = new System.Windows.Forms.ComboBox();
            this.comboBox_a_filter = new System.Windows.Forms.ComboBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.label_d_filter = new System.Windows.Forms.Label();
            this.label_a_filter = new System.Windows.Forms.Label();
            this.groupBox_file = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_measure_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox_voltmeter_settings.SuspendLayout();
            this.groupBox_file.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Keithly_2182.Properties.Resources.settings_24x24;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Settings";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(4, 103);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(76, 13);
            this.label_timeout.TabIndex = 3;
            this.label_timeout.Text = "TimeOut (sec):";
            // 
            // textBox_timeout
            // 
            this.textBox_timeout.Location = new System.Drawing.Point(133, 100);
            this.textBox_timeout.Name = "textBox_timeout";
            this.textBox_timeout.Size = new System.Drawing.Size(48, 20);
            this.textBox_timeout.TabIndex = 4;
            this.textBox_timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_timeout_KeyPress);
            // 
            // textBox_counts_measurements
            // 
            this.textBox_counts_measurements.Location = new System.Drawing.Point(133, 22);
            this.textBox_counts_measurements.Name = "textBox_counts_measurements";
            this.textBox_counts_measurements.Size = new System.Drawing.Size(48, 20);
            this.textBox_counts_measurements.TabIndex = 5;
            this.textBox_counts_measurements.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_counts_measurements_KeyPress);
            // 
            // label_counts_measurements
            // 
            this.label_counts_measurements.AutoSize = true;
            this.label_counts_measurements.Location = new System.Drawing.Point(6, 25);
            this.label_counts_measurements.Name = "label_counts_measurements";
            this.label_counts_measurements.Size = new System.Drawing.Size(115, 13);
            this.label_counts_measurements.TabIndex = 6;
            this.label_counts_measurements.Text = "Counts Measurements:";
            // 
            // label_elapsed_time
            // 
            this.label_elapsed_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_elapsed_time.AutoSize = true;
            this.label_elapsed_time.Location = new System.Drawing.Point(9, 412);
            this.label_elapsed_time.Name = "label_elapsed_time";
            this.label_elapsed_time.Size = new System.Drawing.Size(74, 13);
            this.label_elapsed_time.TabIndex = 8;
            this.label_elapsed_time.Text = "Elapsed Time:";
            // 
            // label_measure_rez
            // 
            this.label_measure_rez.AutoSize = true;
            this.label_measure_rez.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_measure_rez.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_measure_rez.Location = new System.Drawing.Point(508, 31);
            this.label_measure_rez.Name = "label_measure_rez";
            this.label_measure_rez.Size = new System.Drawing.Size(92, 31);
            this.label_measure_rez.TabIndex = 9;
            this.label_measure_rez.Text = "Result";
            // 
            // label_measure_counts
            // 
            this.label_measure_counts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_measure_counts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_measure_counts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_measure_counts.Location = new System.Drawing.Point(848, 26);
            this.label_measure_counts.Name = "label_measure_counts";
            this.label_measure_counts.Size = new System.Drawing.Size(194, 36);
            this.label_measure_counts.TabIndex = 12;
            this.label_measure_counts.Text = "Counts";
            this.label_measure_counts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_units
            // 
            this.comboBox_units.FormattingEnabled = true;
            this.comboBox_units.Items.AddRange(new object[] {
            "nV",
            "µV",
            "mV",
            "V"});
            this.comboBox_units.Location = new System.Drawing.Point(117, 47);
            this.comboBox_units.Name = "comboBox_units";
            this.comboBox_units.Size = new System.Drawing.Size(64, 21);
            this.comboBox_units.TabIndex = 13;
            // 
            // comboBox_range
            // 
            this.comboBox_range.FormattingEnabled = true;
            this.comboBox_range.Items.AddRange(new object[] {
            "Auto",
            "10mV",
            "100mV",
            "1V",
            "10V"});
            this.comboBox_range.Location = new System.Drawing.Point(117, 23);
            this.comboBox_range.Name = "comboBox_range";
            this.comboBox_range.Size = new System.Drawing.Size(64, 21);
            this.comboBox_range.TabIndex = 14;
            // 
            // groupBox_measure_settings
            // 
            this.groupBox_measure_settings.Controls.Add(this.textBox_scale_points);
            this.groupBox_measure_settings.Controls.Add(this.label_chart_scale_points);
            this.groupBox_measure_settings.Controls.Add(this.label_round);
            this.groupBox_measure_settings.Controls.Add(this.textBox_round);
            this.groupBox_measure_settings.Controls.Add(this.label_stat_counts);
            this.groupBox_measure_settings.Controls.Add(this.textBox_stat_counts);
            this.groupBox_measure_settings.Controls.Add(this.label_remove_points);
            this.groupBox_measure_settings.Controls.Add(this.textBox_remove_points);
            this.groupBox_measure_settings.Controls.Add(this.checkBox_chart);
            this.groupBox_measure_settings.Controls.Add(this.label_counts_measurements);
            this.groupBox_measure_settings.Controls.Add(this.textBox_counts_measurements);
            this.groupBox_measure_settings.Controls.Add(this.label_timeout);
            this.groupBox_measure_settings.Controls.Add(this.textBox_timeout);
            this.groupBox_measure_settings.Location = new System.Drawing.Point(8, 200);
            this.groupBox_measure_settings.Name = "groupBox_measure_settings";
            this.groupBox_measure_settings.Size = new System.Drawing.Size(189, 175);
            this.groupBox_measure_settings.TabIndex = 15;
            this.groupBox_measure_settings.TabStop = false;
            this.groupBox_measure_settings.Text = "Measure Settings:";
            // 
            // textBox_scale_points
            // 
            this.textBox_scale_points.Location = new System.Drawing.Point(133, 129);
            this.textBox_scale_points.Name = "textBox_scale_points";
            this.textBox_scale_points.Size = new System.Drawing.Size(48, 20);
            this.textBox_scale_points.TabIndex = 27;
            // 
            // label_chart_scale_points
            // 
            this.label_chart_scale_points.AutoSize = true;
            this.label_chart_scale_points.Location = new System.Drawing.Point(61, 133);
            this.label_chart_scale_points.Name = "label_chart_scale_points";
            this.label_chart_scale_points.Size = new System.Drawing.Size(69, 13);
            this.label_chart_scale_points.TabIndex = 26;
            this.label_chart_scale_points.Text = "Scale Points:";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.Location = new System.Drawing.Point(4, 77);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(42, 13);
            this.label_round.TabIndex = 25;
            this.label_round.Text = "Round:";
            // 
            // textBox_round
            // 
            this.textBox_round.Location = new System.Drawing.Point(133, 74);
            this.textBox_round.Name = "textBox_round";
            this.textBox_round.Size = new System.Drawing.Size(48, 20);
            this.textBox_round.TabIndex = 24;
            this.textBox_round.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_round_KeyPress);
            // 
            // label_stat_counts
            // 
            this.label_stat_counts.AutoSize = true;
            this.label_stat_counts.Location = new System.Drawing.Point(4, 51);
            this.label_stat_counts.Name = "label_stat_counts";
            this.label_stat_counts.Size = new System.Drawing.Size(83, 13);
            this.label_stat_counts.TabIndex = 23;
            this.label_stat_counts.Text = "Statistic Counts:";
            // 
            // textBox_stat_counts
            // 
            this.textBox_stat_counts.Location = new System.Drawing.Point(133, 48);
            this.textBox_stat_counts.Name = "textBox_stat_counts";
            this.textBox_stat_counts.Size = new System.Drawing.Size(48, 20);
            this.textBox_stat_counts.TabIndex = 22;
            this.textBox_stat_counts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_stat_counts_KeyPress);
            // 
            // label_remove_points
            // 
            this.label_remove_points.AutoSize = true;
            this.label_remove_points.Location = new System.Drawing.Point(63, 155);
            this.label_remove_points.Name = "label_remove_points";
            this.label_remove_points.Size = new System.Drawing.Size(67, 13);
            this.label_remove_points.TabIndex = 20;
            this.label_remove_points.Text = "Chart Points:";
            // 
            // textBox_remove_points
            // 
            this.textBox_remove_points.Location = new System.Drawing.Point(133, 151);
            this.textBox_remove_points.Name = "textBox_remove_points";
            this.textBox_remove_points.Size = new System.Drawing.Size(48, 20);
            this.textBox_remove_points.TabIndex = 19;
            this.textBox_remove_points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_remove_points_KeyPress);
            // 
            // checkBox_chart
            // 
            this.checkBox_chart.AutoSize = true;
            this.checkBox_chart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_chart.Location = new System.Drawing.Point(0, 130);
            this.checkBox_chart.Name = "checkBox_chart";
            this.checkBox_chart.Size = new System.Drawing.Size(54, 17);
            this.checkBox_chart.TabIndex = 18;
            this.checkBox_chart.Text = "Chart:";
            this.checkBox_chart.UseVisualStyleBackColor = true;
            this.checkBox_chart.CheckedChanged += new System.EventHandler(this.checkBox_chart_CheckedChanged);
            // 
            // checkBox_save_log
            // 
            this.checkBox_save_log.AutoSize = true;
            this.checkBox_save_log.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_save_log.Location = new System.Drawing.Point(6, 7);
            this.checkBox_save_log.Name = "checkBox_save_log";
            this.checkBox_save_log.Size = new System.Drawing.Size(75, 17);
            this.checkBox_save_log.TabIndex = 17;
            this.checkBox_save_log.Text = "Save Log:";
            this.checkBox_save_log.UseVisualStyleBackColor = true;
            this.checkBox_save_log.CheckedChanged += new System.EventHandler(this.checkBox_save_log_CheckedChanged);
            // 
            // label_units
            // 
            this.label_units.AutoSize = true;
            this.label_units.Location = new System.Drawing.Point(6, 50);
            this.label_units.Name = "label_units";
            this.label_units.Size = new System.Drawing.Size(34, 13);
            this.label_units.TabIndex = 15;
            this.label_units.Text = "Units:";
            // 
            // label_range
            // 
            this.label_range.AutoSize = true;
            this.label_range.Location = new System.Drawing.Point(6, 26);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(42, 13);
            this.label_range.TabIndex = 7;
            this.label_range.Text = "Range:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (.txt)|*.txt";
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.Location = new System.Drawing.Point(6, 27);
            this.label_file_name.Name = "label_file_name";
            this.label_file_name.Size = new System.Drawing.Size(55, 13);
            this.label_file_name.TabIndex = 16;
            this.label_file_name.Text = "File name:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Desktop;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ContextMenuStrip = this.contextMenuStrip1;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(203, 64);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(839, 253);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Image = global::Keithly_2182.Properties.Resources.calculator_16x16;
            this.button_calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_calculate.Location = new System.Drawing.Point(334, 36);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(78, 23);
            this.button_calculate.TabIndex = 19;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_save_file
            // 
            this.button_save_file.Image = global::Keithly_2182.Properties.Resources.save_16x16;
            this.button_save_file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save_file.Location = new System.Drawing.Point(417, 36);
            this.button_save_file.Name = "button_save_file";
            this.button_save_file.Size = new System.Drawing.Size(85, 23);
            this.button_save_file.TabIndex = 18;
            this.button_save_file.Text = "Save Data";
            this.button_save_file.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_save_file.UseVisualStyleBackColor = true;
            this.button_save_file.Click += new System.EventHandler(this.button_save_file_Click);
            // 
            // button_stop
            // 
            this.button_stop.Image = global::Keithly_2182.Properties.Resources.player_stop_16x16;
            this.button_stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stop.Location = new System.Drawing.Point(265, 36);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(57, 23);
            this.button_stop.TabIndex = 11;
            this.button_stop.Text = "Stop";
            this.button_stop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Keithly_2182.Properties.Resources.player_play_16x16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(206, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_voltmeter_settings
            // 
            this.groupBox_voltmeter_settings.Controls.Add(this.comboBox_rate);
            this.groupBox_voltmeter_settings.Controls.Add(this.comboBox_d_filter);
            this.groupBox_voltmeter_settings.Controls.Add(this.comboBox_a_filter);
            this.groupBox_voltmeter_settings.Controls.Add(this.label_rate);
            this.groupBox_voltmeter_settings.Controls.Add(this.label_d_filter);
            this.groupBox_voltmeter_settings.Controls.Add(this.label_a_filter);
            this.groupBox_voltmeter_settings.Controls.Add(this.label_range);
            this.groupBox_voltmeter_settings.Controls.Add(this.comboBox_range);
            this.groupBox_voltmeter_settings.Controls.Add(this.label_units);
            this.groupBox_voltmeter_settings.Controls.Add(this.comboBox_units);
            this.groupBox_voltmeter_settings.Location = new System.Drawing.Point(8, 31);
            this.groupBox_voltmeter_settings.Name = "groupBox_voltmeter_settings";
            this.groupBox_voltmeter_settings.Size = new System.Drawing.Size(189, 161);
            this.groupBox_voltmeter_settings.TabIndex = 20;
            this.groupBox_voltmeter_settings.TabStop = false;
            this.groupBox_voltmeter_settings.Text = "Voltmeter Settings:";
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Items.AddRange(new object[] {
            "fast",
            "medium",
            "slow"});
            this.comboBox_rate.Location = new System.Drawing.Point(117, 131);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(64, 21);
            this.comboBox_rate.TabIndex = 21;
            // 
            // comboBox_d_filter
            // 
            this.comboBox_d_filter.FormattingEnabled = true;
            this.comboBox_d_filter.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.comboBox_d_filter.Location = new System.Drawing.Point(133, 101);
            this.comboBox_d_filter.Name = "comboBox_d_filter";
            this.comboBox_d_filter.Size = new System.Drawing.Size(48, 21);
            this.comboBox_d_filter.TabIndex = 20;
            // 
            // comboBox_a_filter
            // 
            this.comboBox_a_filter.FormattingEnabled = true;
            this.comboBox_a_filter.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.comboBox_a_filter.Location = new System.Drawing.Point(133, 77);
            this.comboBox_a_filter.Name = "comboBox_a_filter";
            this.comboBox_a_filter.Size = new System.Drawing.Size(48, 21);
            this.comboBox_a_filter.TabIndex = 19;
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Location = new System.Drawing.Point(8, 134);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(33, 13);
            this.label_rate.TabIndex = 18;
            this.label_rate.Text = "Rate:";
            // 
            // label_d_filter
            // 
            this.label_d_filter.AutoSize = true;
            this.label_d_filter.Location = new System.Drawing.Point(7, 104);
            this.label_d_filter.Name = "label_d_filter";
            this.label_d_filter.Size = new System.Drawing.Size(61, 13);
            this.label_d_filter.TabIndex = 17;
            this.label_d_filter.Text = "Digital filter:";
            // 
            // label_a_filter
            // 
            this.label_a_filter.AutoSize = true;
            this.label_a_filter.Location = new System.Drawing.Point(7, 80);
            this.label_a_filter.Name = "label_a_filter";
            this.label_a_filter.Size = new System.Drawing.Size(68, 13);
            this.label_a_filter.TabIndex = 16;
            this.label_a_filter.Text = "Analog Filter:";
            // 
            // groupBox_file
            // 
            this.groupBox_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_file.Controls.Add(this.panel1);
            this.groupBox_file.Location = new System.Drawing.Point(203, 323);
            this.groupBox_file.Name = "groupBox_file";
            this.groupBox_file.Size = new System.Drawing.Size(839, 83);
            this.groupBox_file.TabIndex = 21;
            this.groupBox_file.TabStop = false;
            this.groupBox_file.Text = "Save Log:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label_file_name);
            this.panel1.Controls.Add(this.checkBox_save_log);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 57);
            this.panel1.TabIndex = 0;
            // 
            // button_save_settings
            // 
            this.button_save_settings.Image = global::Keithly_2182.Properties.Resources.save_16x16;
            this.button_save_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_save_settings.Location = new System.Drawing.Point(10, 381);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(187, 25);
            this.button_save_settings.TabIndex = 22;
            this.button_save_settings.Text = "SAVE SETTINGS";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 431);
            this.Controls.Add(this.button_save_settings);
            this.Controls.Add(this.groupBox_file);
            this.Controls.Add(this.label_elapsed_time);
            this.Controls.Add(this.groupBox_voltmeter_settings);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_save_file);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox_measure_settings);
            this.Controls.Add(this.label_measure_counts);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.label_measure_rez);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1070, 470);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KEITHLY-2182";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_measure_settings.ResumeLayout(false);
            this.groupBox_measure_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox_voltmeter_settings.ResumeLayout(false);
            this.groupBox_voltmeter_settings.PerformLayout();
            this.groupBox_file.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.TextBox textBox_timeout;
        private System.Windows.Forms.TextBox textBox_counts_measurements;
        private System.Windows.Forms.Label label_counts_measurements;
        private System.Windows.Forms.Label label_elapsed_time;
        private System.Windows.Forms.Label label_measure_rez;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label_measure_counts;
        private System.Windows.Forms.ComboBox comboBox_units;
        private System.Windows.Forms.ComboBox comboBox_range;
        private System.Windows.Forms.GroupBox groupBox_measure_settings;
        private System.Windows.Forms.Label label_units;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.CheckBox checkBox_save_log;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label_file_name;
        private System.Windows.Forms.CheckBox checkBox_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_save_file;
        private System.Windows.Forms.Label label_remove_points;
        private System.Windows.Forms.TextBox textBox_remove_points;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.GroupBox groupBox_voltmeter_settings;
        private System.Windows.Forms.ComboBox comboBox_rate;
        private System.Windows.Forms.ComboBox comboBox_d_filter;
        private System.Windows.Forms.ComboBox comboBox_a_filter;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label label_d_filter;
        private System.Windows.Forms.Label label_a_filter;
        private System.Windows.Forms.GroupBox groupBox_file;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_stat_counts;
        private System.Windows.Forms.TextBox textBox_stat_counts;
        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.TextBox textBox_round;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_scale_points;
        private System.Windows.Forms.Label label_chart_scale_points;
    }
}

