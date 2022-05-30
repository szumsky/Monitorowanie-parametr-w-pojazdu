using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    /// <summary>
    /// Klasa opisująca czujnik
    /// </summary>
    class SensorData
    {
        /// Nazwa czujnika
        public String name { get; set; }
        /// Identyfikator czujnika
        public int id { get; set; }
        /// Stan czujnika
        public String state { get; set; }
        /// Nazwa mierzonej wartości
        public String measure { get; set; }
        /// Odczytana wartość z czujnika
        public float value { get; set; }
        /// Informacja o przekroczeniu wartości nominalnych
        public bool error { get; set; }

        /// Inicjalizacja obiektu czujnika opisująca odczytane z niego dane
        public SensorData(string name, string measureName, float value, bool error)
        {
            this.name = name;
            this.measure = measureName;
            this.value = value;
            this.error = error;
        }
        /// Inicjalizacja obiektu czujnika opisująca jego stan
        public SensorData(string name, int id, string state)
        {
            this.name = name;
            this.id = id;
            this.state = state;
        }
    }
}
