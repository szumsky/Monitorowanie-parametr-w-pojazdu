using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za obsługę głównej strony aplikacji
    /// </summary>
    public partial class MainPage : ContentPage
    {

        /// Inicjalizacja strony
        public MainPage()
        {
            InitializeComponent();
        }

        /// Funkcja obsługująca naciśnięcie przyciusku "Sprawdź połączenie z urządzeniem". Sprawdzane jest połączenie z kontrolerem za pomocą interfejsu Bluetooth. Wykorzystuje klasę Bluetooth.
        public void Button1Clicked(object sender, EventArgs args)
        {
            switch (Bluetooth.CheckConnection())
            {
                case 0:
                    DisplayAlert("Bluetooth", "Połączenie poprawne", "Zamknij");
                    break;
                case 1:
                    DisplayAlert("Bluetooth", "Bluetooth wyłączone", "Zamknij");
                    break;
                case 2:
                    DisplayAlert("Bluetooth", "Połączenie ze złym urządzeniem", "Zamknij");
                    break;
                default:
                    break;
            }

        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Połącz z chmurą". Nawiązywane jest połączenie z bazą danych. Wykorzystuje klasę Cloud.
        public void Button2Clicked(object sender, EventArgs args)
        {
            switch (Cloud.Connect())
            {
                default:
                    DisplayAlert("Cloud", "Połączenie poprawne", "Zamknij");
                    break;
            }
        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Wykonaj pomiar". Wyświetlana jest strona SensorDataPage zawierająca odebrane z czujników dane. Nnastępuje rozpoczęcie nowej sesji pomiarowej.
        private async void Button3Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SensorDataPage());

        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Wczytaj poprzednią sesje". Wyświetlana jest strona SessionsPage zawierająca odczytane z bazy danych sesje pomiarowe.
        private async void Button4Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SessionsPage());
        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Stan czujników". Wyświetlana jest strona SensorsPage zawierająca dane o czujnikach odczytane z kontrolera.
        private async void Button5Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SensorsPage());
        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Kalibracja". Następuje kalibracja kontrolera za pomocą danych zawartych w chmurze. Wykorzustuje klasu Cloud oraz Bluetooth.
        public void Button6Clicked(object sender, EventArgs args)
        {
            Bluetooth.BluetoothWrite(1, 1);
            DisplayAlert("Kalibracja", "Kalibracja zakończona", "Zamknij");
        }

    }
}
