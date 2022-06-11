using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie danych wyświetlanych na stronie SessionDataPage i częściową jej obsługę
    /// </summary>
    class SessionDataViewModel
    {
        /// Kolekcja zawierająca dane pomiarowe z danej sesji
        public ObservableCollection<SensorData> sessionSensorData { get; set; }
        /// Kolekcja zawierająca czasy wykonania pomiarów z danej sesji
        public ObservableCollection<DateTime> sessionDateData { get; set; }
        /// Dana sesja pomiarowa
        Session data { get; set; }
        /// Nazwa sesji pomiarowej
        public string name { get; set; }
        /// Data utworzenia sesji pomiarowej
        public DateTime date { get; set; }
        /// Czas wykonania pomiaru
        public DateTime time { get; set; }

        /// Inicjalizacja klasy i odczytanie danych pomiarowych danej sesji z bazy danych (Cloud), które są wyświetlane na stronie
        public SessionDataViewModel()
        {
            sessionSensorData = new ObservableCollection<SensorData>();
            sessionDateData = new ObservableCollection<DateTime>();
            data = Cloud.ReadSessionData("Sesja 1");
            name = data.name;
            date = data.date;
            int i = 0 , j = 0;
            while (i < data.time.Length)
            {
                sessionDateData.Add(data.time[i]);
                while (data.sessionData[j] != null)
                {
                    sessionSensorData.Add(new SensorData(data.sessionData[j].name, data.sessionData[j].measure, data.sessionData[j].value, data.sessionData[j].error));
                    j++;
                }
                i++;
            }

            //sessionSensorData.Add(new SensorData("Czujnik temperatury1", "Temperatura", 25.0f, false));
            //sessionSensorData.Add(new SensorData("Czujnik temperatury2", "Temperatura", 28.0f, false));
            //sessionSensorData.Add(new SensorData("Czujnik temperatury3", "Temperatura", 123.0f, true));
            //sessionSensorData.Add(new SensorData("Czujnik ciśnienia", "Ciśnienie", 1024.0f, false));

        }

    }
}
