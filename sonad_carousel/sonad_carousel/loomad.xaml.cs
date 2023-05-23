﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using System.Runtime.InteropServices.ComTypes;

namespace sonad_carousel
{
    public partial class loomad : CarouselPage
    {
        string[] dir;
        string[] sonad;
        public loomad(string path)
        {
            string dir_FilePath = Path.Combine(path, "Loomad.txt");
            string dir_Text = File.ReadAllText(path);
            dir = dir_Text.Split(';');
            int length = dir.Length;
            for (int i = 0; i < length - 1; i++)
            {
                string rnd = dir[i];
                sonad = rnd.Split(':');
                var Page = new ContentPage
                {
                    Content = new StackLayout
                    {
                        TabIndex = i,
                        Children =
                        {
                            new Label
                            {
                                FontSize= 20,
                                Text = sonad[0],
                                BackgroundColor = Color.Wheat,
                                TabIndex= i
                            }
                        }
                    }
                };
                Children.Add(Page);
                var lbl = ((StackLayout)Page.Content).Children[0] as Label;
                var tap = new TapGestureRecognizer();
                lbl.GestureRecognizers.Add(tap);
                tap.Tapped += Tap_Tapped;

            }
        }
        bool OnOff = true;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            if (OnOff)
            {
                var lbl = sender as Label;
                string Tekst_on = dir[lbl.TabIndex];
                sonad = Tekst_on.Split(':');
                lbl.Text += " - " + sonad[1];
                OnOff = false;
            }
            else
            {
                var lbl = sender as Label;
                string Tekst_on = dir[lbl.TabIndex];
                sonad = Tekst_on.Split(':');
                lbl.Text = sonad[0];
                OnOff = true;
            }
        }
    }
}