﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rassavada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectTypeof : Rg.Plugins.Popup.Pages.PopupPage
    {
        public SelectTypeof()
        {
            InitializeComponent();
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void TouristPlaces(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExperPage());
        }

        private async void LocalPlaces(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExperPage());
        }

        private async void Culture(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExperPage());
        }

        private async void Historical(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExperPage());
        }
    }
}