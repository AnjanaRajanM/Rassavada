﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rassavada
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NoExperPage())
            {
                BarBackgroundColor = Color.FromHex("#0BBE22"),


            }
                ;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
