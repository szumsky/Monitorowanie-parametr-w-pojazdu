using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Terminal
{
    /// <summary>
    /// Klasa odpowiedzialna za obsługę strony wyświetlającej sesje pomiarowe zawarte w bazie danych
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionsPage : ContentPage
    {

        public SessionsPage()
        {
            InitializeComponent();

        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Powrót". Następuje powrót do poprzedniej strony (MainPage)
        private async void BackClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }
        /// Funkcja obsługująca naciśnięcie jednej z sesji pomiarowych. Następuje przejście do strony SessionDataPage i wyświetlenie danych pomiarowych z danej sesji odczytanych z chmury
        private async void SessionTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SessionDataPage());
        }

    }
}
