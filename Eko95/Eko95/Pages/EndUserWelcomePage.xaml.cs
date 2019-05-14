using Eko95.Services;
using System;

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

            this.listStartAddres.ItemsSource = MockDataStreets.StreetsOfNS;
            this.listEndAddres.ItemsSource = MockDataStreets.StreetsOfNS;

            
        }


        private void OrderDelivery_Clicked(object sender, EventArgs e)
        {

        }

        private void ListStartAddres_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ListEndAddres_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
   
}