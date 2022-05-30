using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie danych wyświetlanych na stronie SensorsPage i częściową jej obsługę
    /// </summary>
    class SensorViewModel
    {
        /// Kolekcja zawierająca dane o czujnikach
        public ObservableCollection<SensorData> Sensors { get; set; }
        /// Dane o pojedynczym czujniku
        SensorData[] data;
        /// Inicjalizacja klasy i odczytanie danych o czujnikach z wykorzystaniem interfejsu Bluetooth, które są wyświetlane na stronie
        public SensorViewModel()
        {
            Sensors = new ObservableCollection<SensorData>();
            data = Bluetooth.ReadSensors();
            for (int i = 0; i < data.Length; i++)
            {
                //Sensors.Add(new SensorData(data[i].name, data[i].id, data[i].state));
            }
            Sensors.Add(new SensorData("Czujnik temperatury1", 0, "Działa poprawnie"));
            Sensors.Add(new SensorData("Czujnik temperatury2",1, "Uszkodzony"));
            Sensors.Add(new SensorData("Czujnik temperatury3", 2, "Działa poprawnie"));
            Sensors.Add(new SensorData("Czujnik ciśnienia", 3, "Działa poprawnie"));
        }
        /// Komenda przypisująca zawierająca funkcję obsługi przycisku "Odświerz"
        public ICommand Refresh => new Command(RefreshClicked);
        /// Funkcja obsługująca naciśnięcie przyciusku "Odświerz". Odczytuje dane o czujnikach z wykorzystaniem interfejsu Bluetooth, które zostają wyświetlone na stronie
        void RefreshClicked()
        {
            Sensors.Clear();
            data = Bluetooth.ReadSensors();
            for (int i = 0; i < data.Length; i++)
            {
                //Sensors.Add(new SensorData(data[i].name, data[i].id, data[i].state));
            }
            Sensors.Add(new SensorData("Czujnik temperatury1", 0, "Działa poprawnie"));
            Sensors.Add(new SensorData("Czujnik temperatury2", 1, "Uszkodzony"));
            Sensors.Add(new SensorData("Czujnik temperatury3", 2, "Uszkodzony"));
            Sensors.Add(new SensorData("Czujnik ciśnienia", 3, "Działa poprawnie"));
        }
    }
}
