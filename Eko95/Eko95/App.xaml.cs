﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eko95.Pages;

namespace Eko95
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomeTabbedPage());

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
