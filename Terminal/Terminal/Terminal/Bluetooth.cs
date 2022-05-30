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
            ble = CrossBluetoothLE.Current;
            adapter = CrossBluetoothLE.Current.Adapter;
            var state = ble.State;
            if (state.ToString() == "Off")
                return 1;

            //int count = adapter.ConnectedDevices.Count;
            device = adapter.ConnectedDevices[0];


            return 0;
        }

        /// Odczytanie danych o podłączonych do kontrolera sensorach
        public static SensorData[] ReadSensors() {
            SensorData[] sensors = {
                new SensorData("a", 0, "1"),
                new SensorData("b", 1, "1"),
                new SensorData("c", 2, "0")
                };
            return sensors;
        }

        /// Odczytanie danych z sensorów
        public static SensorData[] ReadSensorsData() {
            SensorData[] sensorsData = {
                new SensorData("a", "Temp", 50.0f, false),
                new SensorData("b", "Temp", 50.0f, false),
               new SensorData("c", "Temp", 50.0f, true)
                };
            return sensorsData;
        }

        /// Wysłanie danych do kontrolera
        public static void BluetoothWrite(int msg, int value) { }

    }
}
