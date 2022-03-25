using System;
using System.Collections.Generic;
using System.Text;
using CookBook.Views;
using Xamarin.Forms;

namespace CookBook.Services
{
    internal class NavigationService : INavigationService
    {
        public void NavigateToTestPage()
        {
            var vm = App.Locator.testPage;
            Application.Current.MainPage.Navigation.PushModalAsync(new testPage { BindingContext = vm });
        }
    }
}
