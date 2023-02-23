using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ti51
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            MainPage = new Autentication();
            MainPage = new NavigationPage(new Profesores());
            //MainPage = new Inicio();
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
