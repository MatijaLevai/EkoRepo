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
    public partial class WelcomeTabbedPage : TabbedPage
    {
        public WelcomeTabbedPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (LoginMail.Text != null && LoginPass.Text != null && string.IsNullOrWhiteSpace(Mail.Text) && string.IsNullOrWhiteSpace(Pass.Text))
                {
                    string m = LoginMail.Text;
                    string p = LoginPass.Text;
                    if (m == "kuri@eko.com" && p == "pass")
                    {await Navigation.PushAsync(new Page()); }
                    else if (m == "dispatch@eko.com" && p == "pass")
                    { await Navigation.PushAsync(new Page()); }
                    else if (m == "user@eko.com" && p == "pass")
                    {
                        var page = new EndUserWelcomePage();
                        await Navigation.PushAsync(page);
                       
                    }
                }
            }
            catch {await DisplayAlert("Atention!", "Please enter email and password correctly.", "ok?"); }
        }

        private void Register_Clicked(object sender, EventArgs e)
        {

           if (Name.Text != null && Phone != null && Mail.Text != null && Pass.Text != null && string.IsNullOrWhiteSpace(Name.Text) && string.IsNullOrWhiteSpace(Phone.Text) && string.IsNullOrWhiteSpace(Mail.Text) && string.IsNullOrWhiteSpace(Pass.Text))
            {
                if (PassConfirm.Text == Pass.Text)
                { 
                    string name = Name.Text;
                    string phone = Phone.Text;
                    string mail = Mail.Text;
                    string pass = Pass.Text;
                }
            }
            else DisplayAlert("Atention!", "Please fill Entrys correctly.", "ok?");

        }
    }
}