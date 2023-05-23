using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace sonad_carousel
{
    public partial class MainPage : ContentPage
    {
        string text = "Kass:Cat;" + "Koer:Dog;";
        Button corousel, uusloom;
        Editor eloom, vloom;
        Label uus;
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Loomad.txt");
        public MainPage()
        {
            File.WriteAllText(path, text);
            StackLayout stack = new StackLayout();
            corousel = new Button()
            {
                Text = "Loomad carousel",
                BackgroundColor = Color.Wheat,
                CornerRadius= 10,
            };
            uus = new Label()
            {
                Text = "Kirjuta loomi nimi eesti ja inglise keeles",
                BackgroundColor = Color.Wheat,
            };
            eloom = new Editor()
            {
                Placeholder = "Loom eesti keeles"
            };
            vloom = new Editor()
            {
                Placeholder = "Loom inglise keeles"
            };
            uusloom = new Button()
            {
                Text = "Lisa uus loom",
                BackgroundColor = Color.Wheat,
                CornerRadius = 10,
            };
            corousel.Clicked += Corousel_Clicked;
            stack.Children.Add(corousel);
            stack.Children.Add(uus);
            stack.Children.Add(eloom);
            stack.Children.Add(vloom);
            stack.Children.Add(uusloom);
            uusloom.Clicked += Uus_kart_Clicked;
            Content = stack;
        }
        string uus_tekst;
        private void Uus_kart_Clicked(object sender, EventArgs e)
        {
            uus_tekst = eloom.Text + ":" + vloom.Text + ";";
            File.AppendAllText(path, uus_tekst);
            eloom.Text = null;
            vloom.Text = null;
        }

        private async void Corousel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new loomad(path)));
        }
    }
}
