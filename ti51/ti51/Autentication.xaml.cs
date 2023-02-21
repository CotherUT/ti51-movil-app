using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ti51
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Autentication : ContentPage
	{
		public Autentication ()
		{
			InitializeComponent ();
		}

        private void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new MainPage());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}