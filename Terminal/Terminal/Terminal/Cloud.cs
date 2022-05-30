using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za komunikację z bazą danych
    /// </summary>
    static class Cloud
    {

        /// Uchwyt do bazy danych
        static int handle;

        /// Połączenie z bazą danych
        public static int Connect()
        {
            handle = 1;
            return 0;
        }

        /// Odczytanie danych wybranej sesji z bazy danych
        public static Session ReadSessionData(string name)
        {
            Session sessionData = new Session(name, DateTime.Today.Date);

            sessionData.addData(new SensorData("Czujnik temperatury1", "Temperatura", 25.0f, false), DateTime.Now);
            sessionData.addData(new SensorData("Czujnik temperatury2", "Temperatura", 28.0f, false));
            sessionData.addData(new SensorData("Czujnik temperatury3", "Temperatura", 123.0f, true));
            sessionData.addData(new SensorData("Czujnik ciśnienia", "Ciśnienie", 1024.0f, false));
            return sessionData;
        }

        /// Odczytanie sesji z bazy danych
        public static Session[] ReadSessions()
        {
            Session[] sessions = {
                new Session("Sesja 1", DateTime.Now.Date.AddDays(-1)),
                new Session("Sesja 2", DateTime.Now.Date.AddDays(2)),
               new Session("Sesja 3", DateTime.Now.Date.AddDays(3))
                };
            return sessions;
        }

        /// Wysłanie komunikatu do bazy danych
        public static void CloudWrite(int msg, int value) { }

        /// Wysłanie danych do konkretnej sesji w bazie danych
        public static void CloudWriteMeas(string name, SensorData[] sensorsData) { }
    }
}
