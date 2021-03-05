using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Adini
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
            
            
            DisplayAlert("INSTRUCCIONES", "El nuevo resultado multipliquelo por 5", "Listo!");
            DisplayAlert("INSTRUCCIONES", "A el resultado que obtuvo sumele 8", "Siguiente");
            DisplayAlert("INSTRUCCIONES", "Multiplique el numero que penso por 2", "Siguiente");
            DisplayAlert("INSTRUCCIONES", "Piense en un numero", "Siguiente");
            

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());

            DisplayAlert("INSTRUCCIONES", "Sumele el numero de mes de su cumpleaños", "Listo");
            DisplayAlert("INSTRUCCIONES", "Al resultado multipliquelo por 5", "Siguiente");
            DisplayAlert("INSTRUCCIONES", "Al resultado sumale 73", "Siguiente");
            DisplayAlert("INSTRUCCIONES", "Al dia del mes en el cual nacio, multipliquelo por 20", "Siguiente");
        }
    }
}
