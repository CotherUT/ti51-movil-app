using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ti51
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Alumno Registrado Correctamente", "Salir");
            tbNombre.Text = "";
            tbDomicilio.Text = "";
            tbTelefono.Text = "";
            tbCiudad.Text = "";
            tbPassword.Text = "";
            tbUsuario.Text = "";
            edObservaciones.Text = "";
            rbFemenino.IsChecked = false;
            rbMasculino.IsChecked = false;
        }
    }
}
