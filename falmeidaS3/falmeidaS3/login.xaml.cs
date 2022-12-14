using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace falmeidaS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "falmeida";
            string clave = "12345";
            if(usuario==txtUsuario.Text && clave == txtClave.Text) {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contrasela Incorrecto", "Cerrar");
            }
                
        }
    }
}