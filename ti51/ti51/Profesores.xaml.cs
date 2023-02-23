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
	public partial class Profesores : ContentPage
	{
		public List<ProfesorCLS> listaProfesores { get; set; }
		public Profesores ()
		{
			InitializeComponent ();

			listaProfesores= new List<ProfesorCLS> ();

			listaProfesores.Add(new ProfesorCLS { Nombre = "Armando", Carrera = "IDGS", Clave = "abc123" });
			listaProfesores.Add(new ProfesorCLS { Nombre = "Andres", Carrera = "IDGS", Clave = "abc124" });
			listaProfesores.Add(new ProfesorCLS { Nombre = "Antonio", Carrera = "IDGS", Clave = "abc125" });
			listaProfesores.Add(new ProfesorCLS { Nombre = "Carlos", Carrera = "IDGS", Clave = "abc126" });
			listaProfesores.Add(new ProfesorCLS { Nombre = "Pepe", Carrera = "IDGS", Clave = "abc127" });
			BindingContext = this;
		}
	}
}