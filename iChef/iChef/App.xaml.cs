﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iChef
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DishPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
