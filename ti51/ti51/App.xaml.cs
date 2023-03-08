using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ti51
{
    public partial class App : Application
    {
        public static NavigationPage Navigate { get; internal set; }
        public static EstructuraMenu MenuApp { get; internal set; }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Autentication());
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
