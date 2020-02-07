using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsExample
{
    public partial class ContenPageExample : ContentPage
    {
        public ContenPageExample()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            await button.FadeTo(0.5, 450);
            await Task.Delay(200);
            await button.FadeTo(1, 450);
        }
    }
}
