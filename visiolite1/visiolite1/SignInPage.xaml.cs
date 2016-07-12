using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace visiolite1
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();

            Content = new Label
            {
                Text = "Please enter your Microsoft Credentials", //todo:- put at top left of the page
                                                                  //todo:- add username and password fields

            };

            Padding = new Thickness(0, 20, 0, 0);
        }
    }
}
