using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie danych wyświetlanych na stronie SessionsPage i częściową jej obsługę
    /// </summary>
    class SessionViewModel
    {
        /// Kolekcja zawierająca sesje pomiarowe zawarte w bazie danych
        public ObservableCollection<Session> Sessions { get; set; }
        /// Pojedyncza sesja zawarta w bazie danych
        Session[] data;
        /// Inicjalizacja klasy i odczytanie sesji z bazy danych danych (Cloud), które są wyświetlane na stronie
        public SessionViewModel()
        {
            Sessions = new ObservableCollection<Session>();
            data = Cloud.ReadSessions();
            for (int i = 0; i < data.Length; i++)
            {
                //Sessions.Add(new Session(data[i].name, data[i].date));
            }
            Sessions.Add(new Session("Sesja 1", DateTime.Today));
            Sessions.Add(new Session("Sesja 2", DateTime.Today));
            Sessions.Add(new Session("Sesja 3", DateTime.Today));
        }

    }
}
