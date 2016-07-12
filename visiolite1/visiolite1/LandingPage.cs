using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace visiolite1
{
    public class LandingPage : ContentPage
    {
        public LandingPage()
        {
            Content = new Label
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

                        }

                },

                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.Teal,
                TextColor= Color.White,

             
            };

         

        }
    }
}
