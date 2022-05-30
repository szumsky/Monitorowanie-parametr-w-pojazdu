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
    /// Klasa odpowiedzialna za obsługę strony z danymi odczytanymi z czujnika
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SensorDataPage : ContentPage
    {
        /// Inicjalizacja strony
        public SensorDataPage()
        {
            InitializeComponent();
        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Powrót". Następuje powrót do poprzedniej strony (MainPage)
        private async void BackClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}
