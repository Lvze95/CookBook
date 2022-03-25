﻿using CookBook.Services;
using CookBook.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook
{
    public partial class App : Application
    {
        private static IServiceProvider _serviceProvider;
        private static ViewModelLocator _viewModelLocator;
        public App()
        {
            InitializeComponent();
            SetupServices();

            MainPage = new NavigationPage(new MainPage(){ BindingContext = Locator.MainViewModel });
        }

        internal static ViewModelLocator Locator
        {
            get
            {
                if (_viewModelLocator is null)
                {
                    _viewModelLocator = new ViewModelLocator(_serviceProvider);
                }

                return _viewModelLocator;
            }
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

        private void SetupServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<MainViewModel>();
            serviceCollection.AddSingleton<INavigationService, NavigationService>();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
