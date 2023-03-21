using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TI51.Clases;

namespace ti51
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Autentication : ContentPage
	{
        public UsuarioCLS obj_loguin { get; set; } = new UsuarioCLS();
        public Autentication()
		{
			InitializeComponent ();
            BindingContext = this;

        }

        private void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new MainPage());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new MainPage());
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (obj_loguin.usuario == "admin" && obj_loguin.password == "123")
            {
                Application.Current.MainPage = new EstructuraMenu();
            }
            else
            {
                DisplayAlert("ERROR", "Usuario y/o contraseña incorrecta", "Cancelar");
            }
        }

        private void btnRegistrarse_Clicked_1(object sender, EventArgs e)
        {

        }

        private void cbRecordar_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //Click en el checkbox
            if(cbRecordar.IsChecked)
            {
                obj_loguin.usuario = "admin";
                obj_loguin.password= "123";
            }
            else
            {
                obj_loguin.usuario= null;
                obj_loguin.password = null;
            }
        }
    }
}