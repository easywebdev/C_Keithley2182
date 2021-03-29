using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.IO;

namespace Keithly_2182
{
    [Serializable]
    public struct Keithly
    {
        public string portname { set; get; }     // Port Name
        public int baudrate { set; get; }        // Baudrate Speed data transfer (look device settings)
        public Parity parity { set; get; }       // Parity
        public int databits { set; get; }        // Data Bits
        public StopBits stopbits { set; get; }   // Stop Bits
        public Handshake handshake { set; get; } // HandShake
        public int readtimeout { set; get; }     // Read TimeOut waiting responce to read data from device
        public int writetimeout { set; get; }    // Write TimeOut waiting responce to write data to device
    }

    [Serializable]
    public class MSettings
    {
        public int MeasureCounts { set; get; }   // Колличество измерений
        public int StatCounts { set; get; }      // Колличество статистических точек
        public int Round { set; get; }           // Округление (0 - неокруглять)
        public int TimeOut { set; get; }         // Задержка между измерениями
        public string Units { set; get; }        // Единицы измерений Вольтметра
        public string Range { set; get; }        // Диапазон Вольтметра
        public string AFilter { set; get; }      // Агалоговый фильтр Вольтметра
        public string DFilter { set; get; }      // Цифровой фильтр Вольтметра
        public string Rate { set; get; }         // Скорость интегрироватия Вольтметра
        public bool Chart { set; get; }          // Активировать график
        public int DelPoints { set; get; }       // Удаление старых точек с графика
        public int ScalePoints { set; get; }     // Масштабирование графика
    }

    public class Settings
    {
        public Keithly Device { set; get; }
        public MSettings MSet { set; get; }
    }
}
