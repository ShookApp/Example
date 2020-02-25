using Xamarin.Essentials;
using Xamarin.Forms;

namespace FormsExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            // Creates a new instance of the ContentPageExample.
            ContentPageExample contentPageExample = new ContentPageExample();
            // Sets the App as a variable in the ContentPageExample to outsource
            // some methods.
            contentPageExample.SetApp(this);
            
            MainPage = new NavigationPage(contentPageExample);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        internal async void OpenBrowser(string url)
        {
            await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
        }
    }
}
