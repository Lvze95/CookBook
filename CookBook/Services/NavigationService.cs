using System;
using System.Collections.Generic;
using System.Text;
using CookBook.Views;
using Xamarin.Forms;

namespace CookBook.Services
{
    internal class NavigationService : INavigationService
    {

        public void NavigateToDinner()
        {
            var td = App.Locator.ListDinner;
            Application.Current.MainPage.Navigation.PushModalAsync(new ListDinner { BindingContext = td });
        }
    }
}
