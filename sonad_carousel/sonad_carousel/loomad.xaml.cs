using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sonad_carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loomad : CarouselPage
    {
        public loomad()
        {
            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Red",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center,
                        },
                        new BoxView
                        {
                            Color= Color.Red,
                            WidthRequest= 200,
                            HeightRequest= 200,
                            HorizontalOptions= LayoutOptions.Center,
                            VerticalOptions= LayoutOptions.CenterAndExpand,
                        }
                    }
                }
            };
            Children.Add(redContentPage);
        }
    }
}