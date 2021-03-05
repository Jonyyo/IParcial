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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
         
           
            
        }

        private void Button_Clicked(object sender, EventArgs e)

        {
            if(!string.IsNullOrEmpty(Resultado.Text))
            {
                var resultado = int.Parse(Resultado.Text);
                int i, rfinal;
                string anu;

                int numerocaracteres = Resultado.Text.Length;
                anu = Resultado.Text.Substring(0, numerocaracteres - 1);
                i = Convert.ToInt32(anu);
                rfinal = i - 4;

                npensaste.Text = rfinal.ToString();

                DisplayAlert("Numero que pensaste", npensaste.Text, "ok");

            }
            else
            {
                DisplayAlert("Datos erronesos", "Por favor, anota el resultado", "ok");
            }


        }
    }
}