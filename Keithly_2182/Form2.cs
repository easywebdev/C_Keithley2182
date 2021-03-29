using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keithly_2182
{
    public partial class Form2_About : Form
    {
        public Form2_About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_web_page_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://it-experience.xyz/index.php/en/developments-en/for-measuring-instruments-en/82-keithley-2182-data-loger-en");
        }

        private void linkLabel_author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://it-experience.xyz/index.php/en/contacts-en/10-shurygin-fedor");
        }
    }
}
