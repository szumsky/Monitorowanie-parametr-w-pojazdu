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
    /// Klasa odpowiedzialna za obsługę strony z danymi pomiarowymi zawartymi w danej sesji z bazy danych
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionDataPage : ContentPage
    {

        public SessionDataPage()
        {
            InitializeComponent();

        }
        /// Funkcja obsługująca naciśnięcie przyciusku "Powrót". Następuje powrót do poprzedniej strony (SessionPage)
        private async void BackClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SessionsPage());
        }
    }
}
