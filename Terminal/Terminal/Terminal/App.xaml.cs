using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Terminal
{
    /// <summary>
    /// Główna klasa wejściowa aplikacji
    /// </summary>
    public partial class App : Application
    {
        /// Inicjalizacja aplikacji
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        /// Funkcja uruchamiana podczas uruchamiania aplikacja
        protected override void OnStart()
        {
        }
        /// Funkcja uruchamiana podczas usypiania aplikacja
        protected override void OnSleep()
        {
        }
        /// Funkcja uruchamiana podczas wznawiania aplikacja
        protected override void OnResume()
        {
        }
    }
}
