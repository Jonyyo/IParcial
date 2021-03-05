using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adini
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var resultado = int.Parse(Resultado.Text);
            int n;
            string j;
            string dia, mes;

            n = (resultado - 365);
            j = Convert.ToString(n);

            int numerocaracteres = j.Length;

           dia = j.Substring(0, numerocaracteres - 2);
           mes = j.Substring(numerocaracteres - 2, numerocaracteres-2);

            Dia.Text = dia;
           Mes.Text = mes;

            DisplayAlert("El mes de su cumpleaños es", Mes.Text, "ok");
            DisplayAlert("El dia de su cumpleaños es", Dia.Text, "ok");

        }
    }
}