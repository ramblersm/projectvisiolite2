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
            credentialsSubmitButton.Clicked += submitCredentials;
            //Set the default binding to a default object for now
            this.BindingContext = new Credentials();
        }

        private void submitCredentials(object sender, EventArgs e)
        {
           //todo-call method from a different class where credentials validation will take place
            throw new NotImplementedException();
        }
    }
}
