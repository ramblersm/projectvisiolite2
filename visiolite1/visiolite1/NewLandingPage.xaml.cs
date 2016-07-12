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
            Content= new Label
            {
                //landing page message
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                        Text = "Welcome to",
                        FontSize=Device.GetNamedSize(NamedSize.Large ,typeof(Label))
                         },
                        new Span
                        {
                            Text= " Visiolite",
                             FontSize=Device.GetNamedSize(NamedSize.Large ,typeof(Label)),
                             FontAttributes=FontAttributes.Bold
                        }



                        //new Span
                        //  {
                        //    Text = "\n Tap to Continue"

                        //  }
                    }


                   

                },

               HorizontalTextAlignment = TextAlignment.Center,
               VerticalTextAlignment = TextAlignment.Center,
               BackgroundColor = Color.Teal,
               TextColor = Color.White,


            };
            //var continueButton = new Button { Text = "Tap to continue" };
            //continueButton.Clicked += tapToContinue;

        }

        //public void tapToContinue()
        //{

        //    Button gotoModalButton = new Button
        //    {
        //        Text = "Tap to Continue"

        //    };
            async void tapToContinue (object sender, EventArgs args)
            { 
  //{
  //    await Navigation.PopModalAsync();
  //}
  //          gotoModalButton.Clicked += async (sender, args) =>
  //                {
                      await Navigation.PushModalAsync(new SignInPage());
                  }
        
}
}
