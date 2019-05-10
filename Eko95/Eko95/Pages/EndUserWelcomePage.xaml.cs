using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eko95.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndUserWelcomePage : TabbedPage
    {
        public EndUserWelcomePage()
        {
            InitializeComponent();
            Streets.ItemsSource = Eko95.Services.MockDataStreets.StreetsOfNS;
        }

        private void OrderDelivery_Clicked(object sender, EventArgs e)
        {

        }
    }
}