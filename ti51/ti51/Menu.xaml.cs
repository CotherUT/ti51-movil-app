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
		public List<MenuCLS> Items { get; set; }

		public Menu ()
		{
			InitializeComponent ();
		}
	}
}