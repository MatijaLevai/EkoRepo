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

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (LoginMail.Text != null && LoginPass.Text != null)
            {
                string m = LoginMail.Text;
                string p = LoginPass.Text;
            }
            else DisplayAlert("Atention!","Please enter email and password correctly.","ok?");
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            if (Mail.Text != null && Pass.Text != null )
            {
                if (PassConfirm.Text == Pass.Text)
                {
                    string mail = Mail.Text;
                    string pass = Pass.Text;
                }
            }
            else DisplayAlert("Atention!", "Please enter email and password correctly.", "ok?");

        }
    }
}