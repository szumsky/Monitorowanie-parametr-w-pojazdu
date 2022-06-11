using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie danych wyświetlanych na stronie SensorDataPage i częściową jej obsługę
    /// </summary>
    class SensorsDataViewModel
    {
        /// Kolekcja zawierająca dane pomiarowe z czujników
        public ObservableCollection<SensorData> SensorsData { get; set; }
        /// Pojedyncze dane odczytane z czujnika
        SensorData[] data;

        /// Inicjalizacja klasy i odczytanie danych z czujników z wykorzystaniem interfejsu Bluetooth, które są wyświetlane na stronie
        public SensorsDataViewModel()
        {
            SensorsData = new ObservableCollection<SensorData>();
            data = Bluetooth.ReadSensorsData();
            for(int i=0; i < data.Length; i++)
            {
                SensorsData.Add(new SensorData(data[i].name, data[i].measure, data[i].value, data[i].error));
            }
            //Cloud.CloudWrite(1, name);
            //Cloud.CloudWrite(2, date);
            //Cloud.CloudWriteMeas(name, data);
            //SensorsData.Add(new SensorData("Czujnik temperatury1", "Temperatura", 25.0f, false));
            //SensorsData.Add(new SensorData("Czujnik temperatury2", "Temperatura", 28.0f, false));
            //SensorsData.Add(new SensorData("Czujnik temperatury3", "Temperatura", 123.0f, true));
            //SensorsData.Add(new SensorData("Czujnik ciśnienia", "Ciśnienie", 1024.0f, false));
        }

        /// Komenda przypisująca zawierająca funkcję obsługi przycisku "Odświerz"
        public ICommand Refresh => new Command(RefreshClicked);

        /// Funkcja obsługująca naciśnięcie przyciusku "Odświerz". Odczytuje dane z czujników z wykorzystaniem interfejsu Bluetooth, które zostają wyświetlone na stronie
        void RefreshClicked()
        {
            SensorsData.Clear();
            data = Bluetooth.ReadSensorsData();
            for (int i = 0; i < data.Length; i++)
            {
                //SensorsData.Add(new SensorData(data[i].name, data[i].measure, data[i].value, data[i].error));
            }
            //Cloud.CloudWriteMeas(name, data);
            SensorsData.Add(new SensorData("Czujnik temperatury1", "Temperatura", 35.0f, false));
            SensorsData.Add(new SensorData("Czujnik temperatury2", "Temperatura", 22.0f, false));
            SensorsData.Add(new SensorData("Czujnik temperatury3", "Temperatura", 133.0f, true));
            SensorsData.Add(new SensorData("Czujnik ciśnienia", "Ciśnienie", 1028.0f, false));
        }


    }
}
