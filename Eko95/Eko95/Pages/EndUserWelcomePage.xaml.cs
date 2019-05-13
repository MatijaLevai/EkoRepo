using Eko95.Models;
using Eko95.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            this.list.ItemsSource = MockDataStreets.StreetsOfNS;
            /*
                        SfMaps maps = new SfMaps();
                        ImageryLayer layer = new ImageryLayer();
                        maps.Layers.Add(layer);

            xaml
                         <maps:SfMaps.Layers>
                        <maps:ImageryLayer/>
                    </maps:SfMaps.Layers>
                        */
        }


        private void OrderDelivery_Clicked(object sender, EventArgs e)
        {

        }

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
   
}