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

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			
			MenuCLS obj_menu = (MenuCLS)e.SelectedItem;
			switch(obj_menu.opcion)
			{
				case "Materias": 
					App.Navigate.PushAsync(new Materias()); break;
				case "Profesores":
					App.Navigate.PushAsync(new Profesores()); break;
				case "Carreras":
					App.Navigate.PushAsync(new Carreras()); break;
			}
			App.MenuApp.IsPresented = false; //Oculta el menu cuando el usuario le da click a alguna opcion
        }
    }
}