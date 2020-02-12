using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Essentials;

namespace FormsExample
{
    public partial class ContenPageExample : ContentPage
    {
        public ContenPageExample()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs args)
        {
            Button button = (sender as Button);
            await button.FadeTo(0.5, 450);
            await Task.Delay(200);
            await button.FadeTo(1, 450);
        }

        async void Button_OpenBrowser(object sender, EventArgs args)
        {
            await Browser.OpenAsync("https://samofan.hopto.org", BrowserLaunchMode.SystemPreferred);
        }

        void Button_NewPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ContenPageExample());
        }
    }
}
