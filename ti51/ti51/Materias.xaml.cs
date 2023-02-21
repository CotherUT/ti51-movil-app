using System.Collections.Generic;
using ti51.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ti51
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Materias : ContentPage
	{
		public List<MateriasCLS> listaMaterias { get; set; }
		public Materias ()
		{
			InitializeComponent ();
			
			//Instanciar o creal lista de materias
			listaMaterias = new List<MateriasCLS> ();
			//Agregar la informacion estatica de cada materia
			listaMaterias.Add(new MateriasCLS { Nombre = "Api WEBOS", Cuatrimestre = "5", Profesor = "Lizbeth Ibarra", Carrera = "TI" });
			listaMaterias.Add(new MateriasCLS { Nombre = "Desarrollo Mobil", Cuatrimestre = "5", Profesor = "Lizbeth Ibarra", Carrera = "TI" });
			listaMaterias.Add(new MateriasCLS { Nombre = "Integradora", Cuatrimestre = "5", Profesor = "Jazmin Perez", Carrera = "TI" });
			listaMaterias.Add(new MateriasCLS { Nombre = "Api Expresion", Cuatrimestre = "5", Profesor = "Martha Camacho", Carrera = "TI" });
			BindingContext= this;
		}
	}
}