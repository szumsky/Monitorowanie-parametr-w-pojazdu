using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    /// <summary>
    /// Klasa opisująca sesje
    /// </summary>
    class Session
    {
        /// Nazwa sesji
        public String name { get; set; }
        /// Data utworzenia sesji
        public DateTime date { get; set; }
        /// Dane pomiarowe zawarte w sesji
        public SensorData[] sessionData { get; set; }
        /// Czasy wykonania pomiarów zawartych w sesji
        public DateTime[] time { get; set; }
        /// Zmienna wykorzystywana do indeksowania danych
        public int i = 0;
        /// Zmienna wykorzystywana do indeksowania danych
        public int j = 0;

        /// Inicjalizacja obiektu sesji wykorzystywana podczas utworzenia sesji
        public Session(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
            sessionData = new SensorData[10];
            time = new DateTime[10];
        }

        /// Inicjalizacja obiektu sesji umożliwiające zapisanie pełnych danych sesji (tylko do testowania)
        public Session(string name, DateTime date, SensorData[] sessionData, DateTime[] time)
        {
            this.name = name;
            this.date = date;
            this.sessionData = sessionData;
            this.time = time;
        }
        /// Dodanie pojedynczych danych pomiarowych z czujnika do sesji
        public void addData(SensorData data)
        {
            this.sessionData[i] = new SensorData(data.name, data.measure, data.value, data.error);
            i++;
        }
        /// Dodanie pojedynczych danych pomiarowych z czujnika do sesji oraz czasu ich wykonania
        public void addData(SensorData data, DateTime time)
        {
            this.sessionData[i] = new SensorData(data.name, data.measure, data.value, data.error);
            this.time[j] = time;
            i++;
            j++;
        }
    }
}
