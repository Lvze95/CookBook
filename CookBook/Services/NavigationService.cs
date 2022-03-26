using System;
using System.Collections.Generic;
using System.Text;
using CookBook.Views;
using Xamarin.Forms;

namespace CookBook.Services
{
    internal class NavigationService : INavigationService
    {
        public void NavigateToBreakfast()
        {
            var vm = App.Locator.ListBreakfast;
            Application.Current.MainPage.Navigation.PushModalAsync(new ListBreakfast { BindingContext = vm });
        }

        public void NavigateToLunch()
        {
            var tl = App.Locator.ListLunch;
            Application.Current.MainPage.Navigation.PushModalAsync(new ListLunch { BindingContext = tl });
        }

        public void NavigateToDinner()
        {
            var td = App.Locator.ListDinner;
            Application.Current.MainPage.Navigation.PushModalAsync(new ListDinner { BindingContext = td });
        }

        public void NavigateToSnacks()
        {
            var ts = App.Locator.ListSnacks;
            Application.Current.MainPage.Navigation.PushModalAsync(new ListSnacks { BindingContext = ts });
        }
    }
}
