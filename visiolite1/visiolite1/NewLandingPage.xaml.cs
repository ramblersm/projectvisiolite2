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
            //moved the content below to xaml code
            //Content = new Label
            //{
            //    //landing page message
            //    FormattedText = new FormattedString
            //    {
            //        Spans =
            //        {
            //            new Span
            //            {
            //            Text = "Welcome to",
            //            FontSize=Device.GetNamedSize(NamedSize.Large ,typeof(Label))
            //             },
            //            new Span
            //            {
            //                Text= " Visiolite",
            //                 FontSize=Device.GetNamedSize(NamedSize.Large ,typeof(Label)),
            //                 FontAttributes=FontAttributes.Bold
            //            }



            //            //new Span
            //            //  {
            //            //    Text = "\n Tap to Continue"

            //            //  }
            //        }


                   

            //    },

            //   HorizontalTextAlignment = TextAlignment.Center,
            //   VerticalTextAlignment = TextAlignment.Center,
            //   BackgroundColor = Color.Teal,
            //   TextColor = Color.White,


            //};

        }

                async void tapToContinue (object sender, EventArgs args)
            { 
                      await Navigation.PushModalAsync(new SignInPage());
                  }
        
}
}
