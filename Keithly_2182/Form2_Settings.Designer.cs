namespace Keithly_2182
{
    partial class Form2_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Settings));
            this.button_apply = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.keithly2182 = new System.Windows.Forms.TabPage();
            this.label_Port_1 = new System.Windows.Forms.Label();
            this.comboBox_Port1 = new System.Windows.Forms.ComboBox();
            this.label_baudrate1 = new System.Windows.Forms.Label();
            this.comboBox_baudrate1 = new System.Windows.Forms.ComboBox();
            this.label_parity1 = new System.Windows.Forms.Label();
            this.comboBox_parity1 = new System.Windows.Forms.ComboBox();
            this.label_databits1 = new System.Windows.Forms.Label();
            this.textBox_databits1 = new System.Windows.Forms.TextBox();
            this.label_stopbits1 = new System.Windows.Forms.Label();
            this.comboBox_stopbits1 = new System.Windows.Forms.ComboBox();
            this.label_handshake1 = new System.Windows.Forms.Label();
            this.comboBox_handshake1 = new System.Windows.Forms.ComboBox();
            this.label_readtimeout1 = new System.Windows.Forms.Label();
            this.textBox_readtimeout1 = new System.Windows.Forms.TextBox();
            this.label_writetimeout1 = new System.Windows.Forms.Label();
            this.textBox_writetimeout1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.keithly2182.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(12, 276);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(230, 23);
            this.button_apply.TabIndex = 1;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.keithly2182);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 258);
            this.tabControl1.TabIndex = 2;
            // 
            // keithly2182
            // 
            this.keithly2182.Controls.Add(this.textBox_writetimeout1);
            this.keithly2182.Controls.Add(this.label_writetimeout1);
            this.keithly2182.Controls.Add(this.textBox_readtimeout1);
            this.keithly2182.Controls.Add(this.label_readtimeout1);
            this.keithly2182.Controls.Add(this.comboBox_handshake1);
            this.keithly2182.Controls.Add(this.label_handshake1);
            this.keithly2182.Controls.Add(this.comboBox_stopbits1);
            this.keithly2182.Controls.Add(this.label_stopbits1);
            this.keithly2182.Controls.Add(this.textBox_databits1);
            this.keithly2182.Controls.Add(this.label_databits1);
            this.keithly2182.Controls.Add(this.comboBox_parity1);
            this.keithly2182.Controls.Add(this.label_parity1);
            this.keithly2182.Controls.Add(this.comboBox_baudrate1);
            this.keithly2182.Controls.Add(this.label_baudrate1);
            this.keithly2182.Controls.Add(this.comboBox_Port1);
            this.keithly2182.Controls.Add(this.label_Port_1);
            this.keithly2182.Location = new System.Drawing.Point(4, 22);
            this.keithly2182.Name = "keithly2182";
            this.keithly2182.Padding = new System.Windows.Forms.Padding(3);
            this.keithly2182.Size = new System.Drawing.Size(222, 232);
            this.keithly2182.TabIndex = 0;
            this.keithly2182.Text = "Keithly 2182";
            this.keithly2182.UseVisualStyleBackColor = true;
            // 
            // label_Port_1
            // 
            this.label_Port_1.AutoSize = true;
            this.label_Port_1.Location = new System.Drawing.Point(7, 7);
            this.label_Port_1.Name = "label_Port_1";
            this.label_Port_1.Size = new System.Drawing.Size(29, 13);
            this.label_Port_1.TabIndex = 0;
            this.label_Port_1.Text = "Port:";
            // 
            // comboBox_Port1
            // 
            this.comboBox_Port1.FormattingEnabled = true;
            this.comboBox_Port1.Location = new System.Drawing.Point(87, 5);
            this.comboBox_Port1.Name = "comboBox_Port1";
            this.comboBox_Port1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port1.TabIndex = 1;
            // 
            // label_baudrate1
            // 
            this.label_baudrate1.AutoSize = true;
            this.label_baudrate1.Location = new System.Drawing.Point(7, 34);
            this.label_baudrate1.Name = "label_baudrate1";
            this.label_baudrate1.Size = new System.Drawing.Size(58, 13);
            this.label_baudrate1.TabIndex = 2;
            this.label_baudrate1.Text = "BaudRate:";
            // 
            // comboBox_baudrate1
            // 
            this.comboBox_baudrate1.FormattingEnabled = true;
            this.comboBox_baudrate1.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.comboBox_baudrate1.Location = new System.Drawing.Point(87, 32);
            this.comboBox_baudrate1.Name = "comboBox_baudrate1";
            this.comboBox_baudrate1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_baudrate1.TabIndex = 3;
            // 
            // label_parity1
            // 
            this.label_parity1.AutoSize = true;
            this.label_parity1.Location = new System.Drawing.Point(7, 62);
            this.label_parity1.Name = "label_parity1";
            this.label_parity1.Size = new System.Drawing.Size(36, 13);
            this.label_parity1.TabIndex = 4;
            this.label_parity1.Text = "Parity:";
            // 
            // comboBox_parity1
            // 
            this.comboBox_parity1.FormattingEnabled = true;
            this.comboBox_parity1.Location = new System.Drawing.Point(87, 59);
            this.comboBox_parity1.Name = "comboBox_parity1";
            this.comboBox_parity1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_parity1.TabIndex = 5;
            // 
            // label_databits1
            // 
            this.label_databits1.AutoSize = true;
            this.label_databits1.Location = new System.Drawing.Point(7, 90);
            this.label_databits1.Name = "label_databits1";
            this.label_databits1.Size = new System.Drawing.Size(50, 13);
            this.label_databits1.TabIndex = 6;
            this.label_databits1.Text = "DataBits:";
            // 
            // textBox_databits1
            // 
            this.textBox_databits1.Location = new System.Drawing.Point(87, 87);
            this.textBox_databits1.Name = "textBox_databits1";
            this.textBox_databits1.Size = new System.Drawing.Size(121, 20);
            this.textBox_databits1.TabIndex = 7;
            this.textBox_databits1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_databits1_KeyPress);
            // 
            // label_stopbits1
            // 
            this.label_stopbits1.AutoSize = true;
            this.label_stopbits1.Location = new System.Drawing.Point(9, 118);
            this.label_stopbits1.Name = "label_stopbits1";
            this.label_stopbits1.Size = new System.Drawing.Size(49, 13);
            this.label_stopbits1.TabIndex = 8;
            this.label_stopbits1.Text = "StopBits:";
            // 
            // comboBox_stopbits1
            // 
            this.comboBox_stopbits1.FormattingEnabled = true;
            this.comboBox_stopbits1.Location = new System.Drawing.Point(87, 114);
            this.comboBox_stopbits1.Name = "comboBox_stopbits1";
            this.comboBox_stopbits1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_stopbits1.TabIndex = 9;
            // 
            // label_handshake1
            // 
            this.label_handshake1.AutoSize = true;
            this.label_handshake1.Location = new System.Drawing.Point(9, 147);
            this.label_handshake1.Name = "label_handshake1";
            this.label_handshake1.Size = new System.Drawing.Size(65, 13);
            this.label_handshake1.TabIndex = 10;
            this.label_handshake1.Text = "Handshake:";
            // 
            // comboBox_handshake1
            // 
            this.comboBox_handshake1.FormattingEnabled = true;
            this.comboBox_handshake1.Location = new System.Drawing.Point(87, 143);
            this.comboBox_handshake1.Name = "comboBox_handshake1";
            this.comboBox_handshake1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_handshake1.TabIndex = 11;
            // 
            // label_readtimeout1
            // 
            this.label_readtimeout1.AutoSize = true;
            this.label_readtimeout1.Location = new System.Drawing.Point(8, 174);
            this.label_readtimeout1.Name = "label_readtimeout1";
            this.label_readtimeout1.Size = new System.Drawing.Size(77, 13);
            this.label_readtimeout1.TabIndex = 12;
            this.label_readtimeout1.Text = "Read Timeout:";
            // 
            // textBox_readtimeout1
            // 
            this.textBox_readtimeout1.Location = new System.Drawing.Point(87, 171);
            this.textBox_readtimeout1.Name = "textBox_readtimeout1";
            this.textBox_readtimeout1.Size = new System.Drawing.Size(121, 20);
            this.textBox_readtimeout1.TabIndex = 13;
            this.textBox_readtimeout1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_readtimeout1_KeyPress);
            // 
            // label_writetimeout1
            // 
            this.label_writetimeout1.AutoSize = true;
            this.label_writetimeout1.Location = new System.Drawing.Point(8, 201);
            this.label_writetimeout1.Name = "label_writetimeout1";
            this.label_writetimeout1.Size = new System.Drawing.Size(76, 13);
            this.label_writetimeout1.TabIndex = 14;
            this.label_writetimeout1.Text = "Write Timeout:";
            // 
            // textBox_writetimeout1
            // 
            this.textBox_writetimeout1.Location = new System.Drawing.Point(87, 198);
            this.textBox_writetimeout1.Name = "textBox_writetimeout1";
            this.textBox_writetimeout1.Size = new System.Drawing.Size(121, 20);
            this.textBox_writetimeout1.TabIndex = 15;
            this.textBox_writetimeout1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_writetimeout1_KeyPress);
            // 
            // Form2_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 311);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(268, 350);
            this.MinimumSize = new System.Drawing.Size(268, 350);
            this.Name = "Form2_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form2_Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.keithly2182.ResumeLayout(false);
            this.keithly2182.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage keithly2182;
        private System.Windows.Forms.Label label_Port_1;
        private System.Windows.Forms.ComboBox comboBox_Port1;
        private System.Windows.Forms.ComboBox comboBox_baudrate1;
        private System.Windows.Forms.Label label_baudrate1;
        private System.Windows.Forms.ComboBox comboBox_parity1;
        private System.Windows.Forms.Label label_parity1;
        private System.Windows.Forms.TextBox textBox_databits1;
        private System.Windows.Forms.Label label_databits1;
        private System.Windows.Forms.ComboBox comboBox_stopbits1;
        private System.Windows.Forms.Label label_stopbits1;
        private System.Windows.Forms.ComboBox comboBox_handshake1;
        private System.Windows.Forms.Label label_handshake1;
        private System.Windows.Forms.TextBox textBox_writetimeout1;
        private System.Windows.Forms.Label label_writetimeout1;
        private System.Windows.Forms.TextBox textBox_readtimeout1;
        private System.Windows.Forms.Label label_readtimeout1;
    }
}