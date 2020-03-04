using MarvelCharactersApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelCharactersApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuTappedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
