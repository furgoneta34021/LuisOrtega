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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string nombre,double valortotal)
        {
            InitializeComponent();
            txtusuarioConectado.Text = usuario;
            txtnombreestudiante.Text=nombre;
            txtPagar.Text = Convert.ToString(valortotal);
        }
    }
}