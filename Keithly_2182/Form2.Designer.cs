namespace Keithly_2182
{
    partial class Form2_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_About));
            this.groupBox_about = new System.Windows.Forms.GroupBox();
            this.linkLabel_web_page = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_about = new System.Windows.Forms.Label();
            this.groupBox_license = new System.Windows.Forms.GroupBox();
            this.label_license = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_author = new System.Windows.Forms.GroupBox();
            this.linkLabel_author = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_license.SuspendLayout();
            this.groupBox_author.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_about
            // 
            this.groupBox_about.Controls.Add(this.linkLabel_web_page);
            this.groupBox_about.Controls.Add(this.pictureBox1);
            this.groupBox_about.Controls.Add(this.label_about);
            this.groupBox_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_about.Location = new System.Drawing.Point(12, 12);
            this.groupBox_about.Name = "groupBox_about";
            this.groupBox_about.Size = new System.Drawing.Size(562, 113);
            this.groupBox_about.TabIndex = 0;
            this.groupBox_about.TabStop = false;
            this.groupBox_about.Text = "About:";
            // 
            // linkLabel_web_page
            // 
            this.linkLabel_web_page.AutoSize = true;
            this.linkLabel_web_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_web_page.Location = new System.Drawing.Point(225, 85);
            this.linkLabel_web_page.Name = "linkLabel_web_page";
            this.linkLabel_web_page.Size = new System.Drawing.Size(69, 17);
            this.linkLabel_web_page.TabIndex = 2;
            this.linkLabel_web_page.TabStop = true;
            this.linkLabel_web_page.Text = "web page";
            this.linkLabel_web_page.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_web_page_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Keithly_2182.Properties.Resources._2182A;
            this.pictureBox1.Location = new System.Drawing.Point(9, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_about
            // 
            this.label_about.AutoSize = true;
            this.label_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_about.Location = new System.Drawing.Point(222, 30);
            this.label_about.Name = "label_about";
            this.label_about.Size = new System.Drawing.Size(309, 51);
            this.label_about.TabIndex = 0;
            this.label_about.Text = "This is software it is a Keithley 2182 data loger. \r\nSoftware communicate with de" +
    "vice via \r\nRS232 interface.";
            // 
            // groupBox_license
            // 
            this.groupBox_license.Controls.Add(this.label_license);
            this.groupBox_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_license.Location = new System.Drawing.Point(12, 134);
            this.groupBox_license.Name = "groupBox_license";
            this.groupBox_license.Size = new System.Drawing.Size(562, 64);
            this.groupBox_license.TabIndex = 1;
            this.groupBox_license.TabStop = false;
            this.groupBox_license.Text = "License:";
            // 
            // label_license
            // 
            this.label_license.AutoSize = true;
            this.label_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_license.Location = new System.Drawing.Point(97, 30);
            this.label_license.Name = "label_license";
            this.label_license.Size = new System.Drawing.Size(368, 17);
            this.label_license.TabIndex = 1;
            this.label_license.Text = "This is software is a Freware. You can use it and share it.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_author
            // 
            this.groupBox_author.Controls.Add(this.linkLabel_author);
            this.groupBox_author.Controls.Add(this.label1);
            this.groupBox_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_author.Location = new System.Drawing.Point(12, 202);
            this.groupBox_author.Name = "groupBox_author";
            this.groupBox_author.Size = new System.Drawing.Size(562, 105);
            this.groupBox_author.TabIndex = 4;
            this.groupBox_author.TabStop = false;
            this.groupBox_author.Text = "Author:";
            // 
            // linkLabel_author
            // 
            this.linkLabel_author.AutoSize = true;
            this.linkLabel_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_author.Location = new System.Drawing.Point(4, 79);
            this.linkLabel_author.Name = "linkLabel_author";
            this.linkLabel_author.Size = new System.Drawing.Size(145, 17);
            this.linkLabel_author.TabIndex = 1;
            this.linkLabel_author.TabStop = true;
            this.linkLabel_author.Text = "Connect to the author";
            this.linkLabel_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_author_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shurygin Fedor.\r\nIf You have some propositions or \r\nYou\'d like to support author " +
    "You can do it by link below:";
            // 
            // Form2_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 345);
            this.Controls.Add(this.groupBox_author);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_license);
            this.Controls.Add(this.groupBox_about);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.groupBox_about.ResumeLayout(false);
            this.groupBox_about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_license.ResumeLayout(false);
            this.groupBox_license.PerformLayout();
            this.groupBox_author.ResumeLayout(false);
            this.groupBox_author.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_about;
        private System.Windows.Forms.Label label_about;
        private System.Windows.Forms.GroupBox groupBox_license;
        private System.Windows.Forms.Label label_license;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel_web_page;
        private System.Windows.Forms.GroupBox groupBox_author;
        private System.Windows.Forms.LinkLabel linkLabel_author;
        private System.Windows.Forms.Label label1;
    }
}