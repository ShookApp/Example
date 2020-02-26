using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsExample.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnotherPage : TabbedPage
    {
        public AnotherPage()
        {
            InitializeComponent();
        }
    }
}
