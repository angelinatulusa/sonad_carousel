using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sonad_carousel
{
    public partial class MainPage : ContentPage
    {
        Button loomad_btn, puuviljad_btn;
        public MainPage()
        {
            loomad_btn = new Button
            {
                Text = "Loomad",
            };
            puuviljad_btn = new Button
            {
                Text = "Puuviljad"
            };
            loomad_btn.Clicked += Loomad_Clicked;
            puuviljad_btn.Clicked += Puuviljad_Clicked;
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Beige,
                Children = { loomad_btn, puuviljad_btn }
            };
            Content = st;
        }

        private async void Puuviljad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new puuviljad());
        }

        private async void Loomad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new loomad());
        }
    }
}
