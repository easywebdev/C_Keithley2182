using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace Keithly_2182
{
    public partial class Form2_Settings : Form
    {
        public Form2_Settings()
        {
            InitializeComponent();
        }

        public string[] get_ports()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

        private void Form2_Settings_Load(object sender, EventArgs e)
        {
            // Выбираем все имеющиеся в системе СОМ порты и селектим тот что забито в настройках по умолчанию
            comboBox_Port1.Items.AddRange(get_ports());
            comboBox_Port1.SelectedItem = Form1.keithly2182.portname;

            // Селектим baudrate из настроек по умолчанию
            comboBox_baudrate1.SelectedItem = Form1.keithly2182.baudrate.ToString();

            // Выбираем возможне варианты для Parity и селектим селектим то что забито в настройках по умолчанию
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboBox_parity1.Items.Add(s);
            }
            comboBox_parity1.SelectedItem = Form1.keithly2182.parity.ToString();

            // Выводим значение DataBits то что забито в настройках по умолчанию
            textBox_databits1.Text = Form1.keithly2182.databits.ToString();

            // Выбираем возможные значения для StopBits и селектим то что забито в настройках по умолчанию
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                comboBox_stopbits1.Items.Add(s);
            }
            comboBox_stopbits1.SelectedItem = Form1.keithly2182.stopbits.ToString();

            // Выбираем возможные значения Handshake и селектим то что забито в настройках по умолчанию
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                comboBox_handshake1.Items.Add(s);
            }
            comboBox_handshake1.SelectedItem = Form1.keithly2182.handshake.ToString();

            // Выводим значение ReadTimeout то что забито в настройках по умолчанию
            textBox_readtimeout1.Text = Form1.keithly2182.readtimeout.ToString();

            // Выводим значение WriteTimeout то что забито в настройках по умолчанию
            textBox_writetimeout1.Text = Form1.keithly2182.writetimeout.ToString();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            // Заносим в настройки новое значения СОМ порта
            Form1.keithly2182.portname = comboBox_Port1.SelectedItem.ToString();

            // Заносим в настройки новое значение baudrate
            Form1.keithly2182.baudrate = int.Parse(comboBox_baudrate1.SelectedItem.ToString());

            // Заносим в настройки новое значение Parity
            Form1.keithly2182.parity = (Parity)Enum.Parse(typeof(Parity), comboBox_parity1.SelectedItem.ToString());

            // Заносим в настройки новое значение DataBits
            try
            {
                Form1.keithly2182.databits = int.Parse(textBox_databits1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("check Port Settings");
            }

            // Заносим в настройки новое значение StopBits
            Form1.keithly2182.stopbits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_stopbits1.SelectedItem.ToString());

            // Заносим в настройки новое значение Handshake
            Form1.keithly2182.handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_handshake1.SelectedItem.ToString());

            // Заносим в настройки новое значение ReadTimeout
            try
            {
                Form1.keithly2182.readtimeout = int.Parse(textBox_readtimeout1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("check Port Settings");
            }

            // Заносим в настройки новое значение WriteTimeout
            try
            {
                Form1.keithly2182.writetimeout = int.Parse(textBox_writetimeout1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("check Port Settings");
            }

            // Сохраняем настройки
            if(File.Exists("settings.xml"))
            {
                Settings settings = new Settings();
                XmlSerializer SaveSettings = new XmlSerializer(typeof(Settings));
                using (FileStream fs = new FileStream("settings.xml", FileMode.Open))
                {
                    settings = (Settings)SaveSettings.Deserialize(fs);
                }

                settings.Device = Form1.keithly2182;

                using (FileStream fs = new FileStream("settings.xml", FileMode.Create))
                {
                    SaveSettings.Serialize(fs, settings);
                }
            }
        }

        private void textBox_databits1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_readtimeout1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_writetimeout1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
