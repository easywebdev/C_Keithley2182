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
using System.Diagnostics;
using System.Xml.Serialization;

namespace Keithly_2182
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Variables */
        int count_measurements = 1;                        // Колличество измерений
        int stat_counts = 1;                               // Колличество статистических точек
        int _round = 0;                                    // Округление (0 - неокруглять)
        int timeout = 0;                                   // Задержка между измерениями
        int[] mnumbers = new int[0];                       // Номера измерений
        double[] mtime = new double[0];                    // временой интервал между измерениями
        double[] mdata = new double[0];                    // массив с измерениями
        double units = 1;                                  // коеффициент для выведения данных (V, mV, mkV nV)
        DateTime[] mdatetime = new DateTime[0];            // Время измерянной величины
        bool _mstop = false;                               // для команды остановки измерений
        string _range = ":SENSe:VOLTage:DC:RANGe:AUTO ON"; // Диапазон для Keithley 2182
        string _afilter = ":SENSe:VOLTage:DC:LPASs ON";    // Аналоговый фильтр
        string _dfilter = ":SENSe:VOLTage:DC:DFILter ON";  // Цыфровой фильтр
        string _rate = ":SENSe:VOLTage:DC:NPLC 5";         // Время интегрирования
        string _filename = null;                           // Имя файла для ведения логов
        bool _chart = true;                                // Включение / выключение графика
        int _chart_points = 0;                             // Ограничение на количества точек на графике (для масштабирования)
        int _chart_delpoints = 0;                          // Ограничение на количества точек на графике (для удаления из колекции графика)

        /**/

        /* Объекты и экземпляры классов */

        // Создаём экземпляр класса структуры Keithly, в котором будут хранится настройки для прибора 
        public static Keithly keithly2182 = new Keithly(); // Keithly 2182

        // Создаём экземпляр класса SerialPort для Keithly2182
        SerialPort _keithly2182_port = new SerialPort();
        MSettings msettings = new MSettings();

        // Создаём екземпляр класса настроек
        Settings settings = new Settings();

        // Создаём объект для безопасного обращения к елементам из разных потоков
        Object loker = new object();

        /**/

        /* Функции */

        // Устанавливаем настройки по умолчанию
        public void set_default_setting()
        {
            // port settings
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                keithly2182.portname = ports[0];
            }
            keithly2182.baudrate = 19200;
            keithly2182.parity = (Parity)Enum.Parse(typeof(Parity), "None");
            keithly2182.databits = 8;
            keithly2182.stopbits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            keithly2182.handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
            keithly2182.readtimeout = 1800;
            keithly2182.writetimeout = 1800;

            // Measure settings
            msettings.MeasureCounts = count_measurements;
            msettings.StatCounts = stat_counts;
            msettings.Round = _round;
            msettings.TimeOut = timeout;
            msettings.Units = "mV";
            msettings.Range = "Auto";
            msettings.AFilter = "ON";
            msettings.DFilter = "ON";
            msettings.Rate = "slow";
            msettings.Chart = _chart;
            msettings.ScalePoints = _chart_points;
            msettings.DelPoints = _chart_delpoints;
        }

        // Устанавливаем настройки
        public void set_settings()
        {
            msettings.Range = comboBox_range.SelectedItem.ToString();
            msettings.Units = comboBox_units.SelectedItem.ToString();
            msettings.AFilter = comboBox_a_filter.SelectedItem.ToString();
            msettings.DFilter = comboBox_d_filter.SelectedItem.ToString();
            msettings.Rate = comboBox_rate.SelectedItem.ToString();

            try
            {
                msettings.MeasureCounts = int.Parse(textBox_counts_measurements.Text);
            }
            catch(Exception ex)
            {
                textBox_counts_measurements.Text = msettings.MeasureCounts.ToString();
                MessageBox.Show("Error!\nMeasure Counts must be Integer > 0\nThe last used value was set\n" + ex);
            }

            try
            {
                msettings.StatCounts = int.Parse(textBox_stat_counts.Text);
            }
            catch(Exception ex)
            {
                textBox_stat_counts.Text = msettings.StatCounts.ToString();
                MessageBox.Show("Error!\nStatistic Counts must be Integer > 0\nThe last used value was set\n" + ex);
            }

            try
            {
                msettings.Round = int.Parse(textBox_round.Text);
            }
            catch(Exception ex)
            {
                textBox_round.Text = msettings.Round.ToString();
                MessageBox.Show("Error!\nRound must be Integer\nThe last used value was set\n" + ex);
            }

            try
            {
                msettings.TimeOut = int.Parse(textBox_timeout.Text);
            }
            catch(Exception ex)
            {
                textBox_timeout.Text = msettings.TimeOut.ToString();
                MessageBox.Show("Error!\nTime Out must be Integer\nThe last used value was set\n" + ex);
            }

            msettings.Chart = _chart;

            try
            {
                msettings.DelPoints = int.Parse(textBox_remove_points.Text);
            }
            catch(Exception ex)
            {
                textBox_remove_points.Text = msettings.DelPoints.ToString();
                MessageBox.Show("Error!\nChart Points must be Integer\nThe last used value was set\n" + ex);
            }

            try
            {
                msettings.ScalePoints = int.Parse(textBox_scale_points.Text);
            }
            catch (Exception ex)
            {
                textBox_scale_points.Text = msettings.ScalePoints.ToString();
                MessageBox.Show("Error!\nChart Points must be Integer\nThe last used value was set\n" + ex);
            }
        }

        //Устанавливаем настройки по умолчанию для работы с устройством
        public void set_default_ports_settings()
        {
            // Получаем все порыты и устанавливаем второй по умолчанию
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                if (ports.Length >= 2)
                {
                    keithly2182.portname = ports[1];
                }
                else
                {
                    keithly2182.portname = ports[0];
                }
            }

            // Устанавливаем BaudRate по умолчанию
            keithly2182.baudrate = 19200;

            // Устанавливаем Parity по умолчанию
            string string_parity = "None";
            keithly2182.parity = (Parity)Enum.Parse(typeof(Parity), string_parity);

            // Устанавливаем DataBits по умолчанию
            keithly2182.databits = 8;

            // Устанавливаем StopBits по умолчанию
            keithly2182.stopbits = (StopBits)Enum.Parse(typeof(StopBits), "One");

            // Устанавливаем Handshake по умолчанию
            keithly2182.handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");

            // Устанавливаем ReadTimeout по умолчанию
            keithly2182.readtimeout = 1800;

            // Устанавливаем WriteTimeout по умолчанию
            keithly2182.writetimeout = 1800;
        }

        // Функция для открытия порта
        public void open_port(SerialPort _port)
        {
            _port.PortName = keithly2182.portname;
            _port.BaudRate = keithly2182.baudrate;
            _port.Parity = keithly2182.parity;
            _port.DataBits = keithly2182.databits;
            _port.StopBits = keithly2182.stopbits;
            _port.Handshake = keithly2182.handshake;
            _port.ReadTimeout = keithly2182.readtimeout;
            _port.WriteTimeout = keithly2182.writetimeout;

            if (!_port.IsOpen)
            {
                _port.Open();
            }
        }

        // Функция для закрытия порта
        public void close_port(SerialPort _port)
        {
            if(_port.IsOpen)
            {
                _port.Close();
            }
        }

        // Функция для вывода результата в лабел на окно программы
        public void input_rez_label(double rez)
        {
            string outrez = rez.ToString() + " (" + comboBox_units.SelectedItem.ToString() + ")";
            label_measure_rez.Text = outrez;
        }

        // Функция для изменения размера массива
        public void Arr_Resize(int n)
        {
            Array.Resize(ref mnumbers, n);
            Array.Resize(ref mdata, n);
            Array.Resize(ref mdatetime, n);
            Array.Resize(ref mtime, n);
        }

        // Функция, которая устанавливает коеффициент для единиц измерения
        public void set_units()
        {
            switch(comboBox_units.SelectedItem.ToString())
            {
                case "nV":
                    units = Math.Pow(10, 9);
                    break;
                case "µV":
                    units = Math.Pow(10, 6);
                    break;
                case "mV":
                    units = Math.Pow(10, 3);
                    break;
                case "V":
                    units = 1;
                    break;
            }
        }

        // Функция которая устанавливает диапазон для Keithley 2182
        public void set_range()
        {
            switch(comboBox_range.SelectedItem.ToString())
            {
                case "Auto":
                    _range = ":SENSe:VOLTage:DC:RANGe:AUTO ON";
                    break;
                case "10mV":
                    _range = ":SENSe:VOLTage:DC:RANGe 0.01";
                    break;
                case "100mV":
                    _range = ":SENSe:VOLTage:DC:RANGe 0.1";
                    break;
                case "1V":
                    _range = ":SENSe:VOLTage:DC:RANGe 1";
                    break;
                case "10V":
                    _range = ":SENSe:VOLTage:DC:RANGe 10";
                    break;
            }
        }

        // Функция установки аналогового фильтра
        public void set_afilter()
        {
            switch(comboBox_a_filter.SelectedItem.ToString())
            {
                case "ON":
                    _afilter = ":SENSe:VOLTage:DC:LPASs ON";
                    break;
                case "OFF":
                    _afilter = ":SENSe:VOLTage:DC:LPASs OFF";
                    break;
            }
        }

        // Функция установки цыфрового фильтра
        public void set_dfilter()
        {
            switch(comboBox_d_filter.SelectedItem.ToString())
            {
                case "ON":
                    _dfilter = ":SENSe:VOLTage:DC:DFILter ON";
                    break;
                case "OFF":
                    _dfilter = ":SENSe:VOLTage:DC:DFILter OFF";
                    break;
            }
        }

        // Функция устанеовки времени интегрирования
        public void set_rate()
        {
            switch(comboBox_rate.SelectedItem.ToString())
            {
                case "fast":
                    _rate = ":SENSe:VOLTage:DC:NPLC 0.01";
                    break;
                case "medium":
                    _rate = ":SENSe:VOLTage:DC:NPLC 1";
                    break;
                case "slow":
                    _rate = ":SENSe:VOLTage:DC:NPLC 5";
                    break;
            }
        }

        // Функция установки подписей к осям графика
        public void set_chart_titles(string units_X, string units_Y)
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Title = units_X;
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Voltage, " + units_Y;
        }

        // Функция блокировки итерфейса на веремя измерений
        public void block_iface()
        {
            groupBox_measure_settings.Enabled = false;
            groupBox_voltmeter_settings.Enabled = false;
            button1.Enabled = false;
            button_save_file.Enabled = false;
            toolStripMenuItem1.Enabled = false;
            button_calculate.Enabled = false;
        }

        // Функция разблокировки итерфейса полсле завершения измерений
        public void unblock_iface()
        {
            groupBox_measure_settings.Enabled = true;
            groupBox_voltmeter_settings.Enabled = true;
            button1.Enabled = true;
            button_save_file.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            button_calculate.Enabled = true;
        }

        // Функция которая строит график
        public void plot_chart(int i, int counts, int delpoints)
        {
            if(Math.Abs(mdata[i]) < (Double)Decimal.MaxValue)
            {
                chart1.Series[0].Points.AddXY(mnumbers[i], mdata[i]);
            }

            if (delpoints > 0) // Если надо удалять точки с графика
            {
                if (chart1.Series[0].Points.Count > delpoints)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.ResetAutoValues();
                }
            }

            if (counts > 0)
            {
                if (chart1.Series[0].Points.Count > counts)
                {
                    chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = mnumbers[i] - counts;
                    chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Size = counts - 3;
                }
            }
        }

        // Функция записи в файл
        public void save_log(string filename, string data, bool append_data)
        {
            using (StreamWriter outfile = new StreamWriter(filename, append_data))
            {
                outfile.WriteLine(data);
            }
        }

        // Функция считывания данных с устройства, которая выполняэться в отдельном потоке
        public void read1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < count_measurements; i++)
            {
                // Если была нажата клавиша STOP
                if (_mstop)
                {
                    count_measurements = i;
                    Arr_Resize(count_measurements);
                    _mstop = false;
                    timeout = 0;
                    unblock_iface();
                    break;
                }

                try
                {
                    double _V = 0;
                    string tmpdata = null;

                    for (int j = 0; j <stat_counts; j++)
                    {
                        // если останавливаем измерения
                        if (_mstop)
                        {
                            if (j != 0)
                            {
                                stat_counts = j;
                            }
                            else
                            {
                                stat_counts = 1;
                            }
                            break;
                        }

                        _keithly2182_port.WriteLine(":READ?");
                        tmpdata = _keithly2182_port.ReadLine();      // Read query
                        _V += double.Parse(tmpdata.Replace(".", ","));
                    }

                    mdata[i] = (_V / stat_counts) * units;
                    if(_round != 0)
                    {
                        mdata[i] = Math.Round(mdata[i], _round);
                    }
                    mnumbers[i] = i + 1;
                    mdatetime[i] = DateTime.Now;
                    mtime[i] = (mdatetime[i] - mdatetime[0]).TotalMilliseconds;

                    if(_filename != null)
                    {
                        string file_data = mnumbers[i] + ";" + mdatetime[i] + ";" + mtime[i] + ";" + mdata[i];
                        save_log(_filename, file_data, true);
                    }

                    this.Invoke(new ThreadStart(() =>
                    {
                        lock (loker)
                        {
                            input_rez_label(mdata[i]);
                            label_measure_counts.Text = (i+1).ToString() + " / " + count_measurements.ToString();
                        }

                        if (_chart)
                        {
                            plot_chart(i, _chart_points, _chart_delpoints);
                        }

                    }
                    ));
                }
                catch(Exception)
                {
                    MessageBox.Show("Error! /r/n Check devices port settings");
                    break;
                }

                // Если была нажата клавиша STOP
                if (_mstop)
                {
                    count_measurements = i;
                    Arr_Resize(count_measurements);
                    _mstop = false;
                    timeout = 0;
                    unblock_iface();
                    break;
                }

                Thread.Sleep(timeout);
            }

            //_keithly2182_port.WriteLine("*CLS");
            close_port(_keithly2182_port);

            sw.Stop();
            string time = sw.ElapsedMilliseconds.ToString();

            this.Invoke(new ThreadStart(() =>
            {
                label_elapsed_time.Text = "Elapsed time: " + time + " msec.";
                checkBox_save_log.Checked = false;
            }));

            unblock_iface();
        }
        /**/

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2_Settings Settings = new Form2_Settings();
            Settings.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_About About = new Form2_About();
            About.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            block_iface();
            _mstop = false;

            try
            {
                count_measurements = int.Parse(textBox_counts_measurements.Text);
            }
            catch(Exception ex)
            {
                textBox_counts_measurements.Text = count_measurements.ToString();
                MessageBox.Show("Error!\nMeasure Counts must be Integer > 0\nThe default value was set\n" + ex);
            }
            
            Arr_Resize(count_measurements);

            try
            {
                stat_counts = int.Parse(textBox_stat_counts.Text);
            }
            catch(Exception ex)
            {
                textBox_stat_counts.Text = msettings.StatCounts.ToString();
                MessageBox.Show("Error!\nStatistic Counts must be Integer > 0\nThe default value was set\n" + ex);
            }

            try
            {
                _round = int.Parse(textBox_round.Text);
            }
            catch(Exception ex)
            {
                textBox_round.Text = msettings.Round.ToString();
                MessageBox.Show("Error!\nRound must be Integer\nThe default value was set\n" + ex);
            }

            try
            {
                timeout = int.Parse(textBox_timeout.Text) * 1000;
            }
            catch (Exception ex)
            {
                textBox_timeout.Text = msettings.TimeOut.ToString();
                MessageBox.Show("Error!\nTime Out must be Integer\nThe default value was set\n" + ex);
            }

            // настройки для вольметра
            set_units();
            set_range();
            set_afilter();
            set_dfilter();
            set_rate();

            // Если установлена галгочка "строить график"
            if(_chart)
            {
                set_chart_titles("Points", comboBox_units.SelectedItem.ToString());
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(); // Сбрасываем скролбар
                chart1.ResetAutoValues();
                try
                {
                    _chart_points = int.Parse(textBox_scale_points.Text);
                }
                catch(Exception ex)
                {
                    textBox_remove_points.Text = msettings.ScalePoints.ToString();
                    MessageBox.Show("Error!\nChart Points must be Integer\nThe default value was set\n" + ex);
                }
                try
                {
                    _chart_delpoints = int.Parse(textBox_remove_points.Text);
                }
                catch (Exception ex)
                {
                    textBox_remove_points.Text = msettings.DelPoints.ToString();
                    MessageBox.Show("Error!\nChart Points must be Integer\nThe default value was set\n" + ex);
                }
            }

            // Если установлена галочка "писать лог"
            if(_filename !=null)
            {
                string file_tittle = "#;Date;TimeSpan (msec);Voltage (" + comboBox_units.SelectedItem.ToString() + ")";
                save_log(_filename, file_tittle, false);
            }

            label_file_name.Text = "File name: " + _filename;

            open_port(_keithly2182_port);
            _keithly2182_port.WriteLine("*RST");                            // при сбросе скорость выходит на slow
            _keithly2182_port.WriteLine(":INITiate:CONTinuous OFF;:ABORt"); // Init off
            _keithly2182_port.WriteLine(":SENSe:FUNCtion 'VOLTage:DC'");    // DCV
            _keithly2182_port.WriteLine(_range);                            // Range (auto; 0.01; 0.1; 1; 10) V
            _keithly2182_port.WriteLine(":SYSTem:AZERo:STATe OFF");         // Auto zero off
            _keithly2182_port.WriteLine(_rate);                             // NPLC (0.01 - fast; 1 - medium; 5 - slow)
            //_keithly2182_port.WriteLine(":DISPlay:ENABle OFF");           // Device display OFF
            _keithly2182_port.WriteLine(_afilter);                          // Analog filter
            _keithly2182_port.WriteLine(_dfilter);                          // Digital filter
            _keithly2182_port.WriteLine(":TRIGger:COUNt 1");                // Trig count 1

            Thread readthread1 = new Thread(read1);
            readthread1.IsBackground = true;
            readthread1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Устанавливаем настройки для прибора и измерений
            XmlSerializer SaveSettings = new XmlSerializer(typeof(Settings));

            if (File.Exists("settings.xml"))
            {
                using (FileStream fs = new FileStream("settings.xml", FileMode.Open))
                {
                    settings = (Settings)SaveSettings.Deserialize(fs);
                    keithly2182 = settings.Device;
                    msettings = settings.MSet;
                }
            }
            else
            {
                set_default_setting();
                settings.Device = keithly2182;
                settings.MSet = msettings;

                using (FileStream fs = new FileStream("settings.xml", FileMode.Create))
                {
                    SaveSettings.Serialize(fs, settings);
                }
            }

            // Задаём настройки диапазона по умолчанию
            comboBox_range.SelectedItem = msettings.Range;

            // Устанавливаем количество измерений по умолчанию и статистика и округление
            textBox_counts_measurements.Text = msettings.MeasureCounts.ToString();
            textBox_stat_counts.Text = msettings.StatCounts.ToString();
            textBox_round.Text = msettings.Round.ToString();
            textBox_timeout.Text = msettings.TimeOut.ToString();

            // Устанавливаем единицы измерения по умолчанию
            comboBox_units.SelectedItem = msettings.Units;

            // Устанавливаем аналоговый фильтр
            comboBox_a_filter.SelectedItem = msettings.AFilter;

            // Устанавливаем цыфровой фильтр
            comboBox_d_filter.SelectedItem = msettings.DFilter;

            // Устанавливаем время интегрирования
            comboBox_rate.SelectedItem = msettings.Rate;

            // Установки для графика по умолчанию
            checkBox_chart.CheckedChanged -= checkBox_chart_CheckedChanged;
            checkBox_chart.Checked = true;
            checkBox_chart.CheckedChanged += checkBox_chart_CheckedChanged;
            textBox_remove_points.Text = msettings.DelPoints.ToString();
            textBox_scale_points.Text = msettings.ScalePoints.ToString();
            chart1.ChartAreas["ChartArea1"].AxisY.IsStartedFromZero = false;
            chart1.Series[0].Points.Clear();
        }

        private void textBox_counts_measurements_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_stat_counts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_round_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox_timeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            _mstop = true;
        }

        private void checkBox_save_log_CheckedChanged(object sender, EventArgs e)
        {
            if(_filename == null && checkBox_save_log.Checked == true)
            {
                if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
                else
                {
                    _filename = null;
                    checkBox_save_log.CheckedChanged -= checkBox_save_log_CheckedChanged;
                    checkBox_save_log.Checked = false;
                    checkBox_save_log.CheckedChanged += checkBox_save_log_CheckedChanged;
                }
            }
            else
            {
                _filename = null;
                checkBox_save_log.CheckedChanged -= checkBox_save_log_CheckedChanged;
                checkBox_save_log.Checked = false;
                checkBox_save_log.CheckedChanged += checkBox_save_log_CheckedChanged;
            }
            label_file_name.Text = "File name: " + _filename;
        }

        private void button_save_file_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _filename = saveFileDialog1.FileName;
                using (StreamWriter outfile = new StreamWriter(_filename))
                {
                    outfile.WriteLine("#;Date;TimeSpan (msec);Voltage (" + comboBox_units.SelectedItem.ToString() + ")");
                    for (int i = 0; i < count_measurements; i++)
                    {
                        outfile.WriteLine(mnumbers[i] + ";" + mdatetime[i] + ";" + mtime[i] + ";" + mdata[i]);
                    }
                }
            }
            _filename = null;
        }

        private void checkBox_chart_CheckedChanged(object sender, EventArgs e)
        {
            if(_chart)
            {
                _chart = false;
            }
            else
            {
                _chart = true;
            }
        }

        private void textBox_remove_points_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            if(mdata.Length > 0)
            {
                double _summ = 0;
                double _calcrez = 0;
                double _err = 0;
                double _relative_err = 0;

                for (int i = 0; i < count_measurements; i++)
                {
                    _summ = _summ + mdata[i];
                }

                _calcrez = _summ / mdata.Length;

                for (int i = 0; i < count_measurements; i++)
                {
                    _err = _err + System.Math.Pow((mdata[i] - _calcrez), 2);
                }

                _err = System.Math.Pow((_err / (mdata.Length * (mdata.Length - 1))), 0.5);
                _relative_err = (_err / _calcrez) * 100;

                label_measure_rez.Text = System.Math.Round(_calcrez, 6) + " (" + comboBox_units.SelectedItem.ToString() + ") " + System.Math.Round(_relative_err, 6) + " %";
            }
            else
            {
                MessageBox.Show("Get the Result before Calculate");
            }

        }

        private void button_save_settings_Click(object sender, EventArgs e)
        {
            set_settings();

            XmlSerializer SaveSettings = new XmlSerializer(typeof(Settings));

            if (File.Exists("settings.xml"))
            {
                using (FileStream fs = new FileStream("settings.xml", FileMode.Open))
                {
                    settings = (Settings)SaveSettings.Deserialize(fs);
                }

                settings.MSet = msettings;

                using (FileStream fs = new FileStream("settings.xml", FileMode.Create))
                {
                    SaveSettings.Serialize(fs, settings);
                }
            }

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.ZoomReset(); // Сбрасываем скролбар
        }
    }
}
