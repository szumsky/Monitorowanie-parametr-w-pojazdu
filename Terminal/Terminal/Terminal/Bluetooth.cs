using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;


namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za komunikację Bluetooth
    /// </summary>
    static class Bluetooth
    {

        /// Uchwyt interfejsu Bluetooth
        static IBluetoothLE ble;
        /// Adapter interfejsu Bluetooth
        static IAdapter adapter;
        /// Połączone urządzenie
        static IDevice device;

        /// Sprawdzenie połączenia i inicjalizacja zmiennych
        public static int CheckConnection()
        {
            //ble = CrossBluetoothLE.Current;
            //adapter = CrossBluetoothLE.Current.Adapter;
            //var state = ble.State;
            //if (state.ToString() == "Off")
            //    return 1;

            //int count = adapter.ConnectedDevices.Count;
            //device = adapter.ConnectedDevices[0];


            return 0;
        }

        /// Odczytanie danych o podłączonych do kontrolera sensorach
        public static SensorData[] ReadSensors() {
            SensorData[] sensors = {
                new SensorData("Czujnik temperatury1", 0, "Działa poprawnie"),
                new SensorData("Czujnik temperatury2",1, "Uszkodzony"),
                new SensorData("Czujnik temperatury3", 2, "Działa poprawnie"),
                new SensorData("Czujnik ciśnienia", 3, "Działa poprawnie")
                };
            return sensors;
        }

        /// Odczytanie danych z sensorów
        public static SensorData[] ReadSensorsData() {
            SensorData[] sensorsData = {
                new SensorData("Czujnik temperatury1", "Temperatura", 25.0f, false),
                new SensorData("Czujnik temperatury2", "Temperatura", 22.0f, false),
                new SensorData("Czujnik temperatury3", "Temperatura", 135.0f, true),
                new SensorData("Czujnik ciśnienia", "Ciśnienie", 1025.0f, false)
                };
            return sensorsData;
        }

        /// Wysłanie danych do kontrolera
        public static void BluetoothWrite(int msg, int value) { }

    }
}
