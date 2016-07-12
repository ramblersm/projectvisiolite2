using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace visiolite1
{
    public partial class NewLandingPage : ContentPage
    {
        public NewLandingPage()
        {
            InitializeComponent();
            continueButton.Clicked += tapToContinue;


        }

                async void tapToContinue (object sender, EventArgs args)
            {
                      
                     await Navigation.PushModalAsync(new SignInPage());
                      //todo- handle backward navigation
                  }
        
}
}
