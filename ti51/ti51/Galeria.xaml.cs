using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ti51.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ti51
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Galeria : ContentPage
	{
		public Galeria ()
		{
			InitializeComponent ();
			List<GaleriaCLS> obj_imagen = new List<GaleriaCLS>()
			{
				new GaleriaCLS() {titulo = "imagen1", imagen="UTN.png" },
				new GaleriaCLS() {titulo = "imagen2", imagen="idgs.jpg" }
			};

			Carousel.ItemsSource = obj_imagen;
		}
	}
}