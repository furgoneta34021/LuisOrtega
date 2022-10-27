using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LuisOrtega
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double valortotal = 3000;
        double Valorinicial = 0;
        double cuotaMensual = 0;
        double valortotalfinal = 0;
        string user;

        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es :" + usuario;
            user = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
       
            Valorinicial = Convert.ToDouble(txtMonto.Text);
            cuotaMensual = ((valortotal - Valorinicial) / 5 + 0.05 * valortotal);
            txtPagoInicial.Text = Convert.ToString(cuotaMensual);
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Elemento guardado con Exito", "Cerrar");
            valortotalfinal = valortotal + cuotaMensual * 5;
            await Navigation.PushAsync(new Resumen(user,txtNombre.Text, valortotalfinal));

        }

        private  void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txtValor = e.NewTextValue;
            var entryns = sender as Entry;

            if (!string.IsNullOrEmpty(txtValor))
            {

                if (Convert.ToDecimal(txtValor) <3000 && Convert.ToDecimal(txtValor)>0)
                {
                    entryns.BackgroundColor = Color.Green;
                }
                else
                {
                    Error.Text = "Valor invalido";
                    entryns.BackgroundColor = Color.Red;



                }
            }
            else
            {
                entryns.Text = txtValor;

            }

        }
    }
}