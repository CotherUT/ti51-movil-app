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
	public partial class Menu : ContentPage
	{
		//Creamos el objeto de tipo lista de clase
		public List<MenuCLS> listaMenu { get; set; }

		public Menu ()
		{
			InitializeComponent ();

			listaMenu= new List<MenuCLS> ();

			listaMenu.Add(new MenuCLS { icono = "ic_materias", opcion = "Materias" });
			listaMenu.Add(new MenuCLS { icono = "ic_profesores", opcion = "Profesores" });
			listaMenu.Add(new MenuCLS { icono = "ic_carreras", opcion = "Carreras" });
			BindingContext = this;
        }
	}
}