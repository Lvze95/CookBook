using CookBook.Models;
using CookBook.Views;
using Xamarin.Forms;

namespace CookBook.Services
{
    internal class NavigationService : INavigationService
    {
        public void NavigateToListOfMeals(string category)
        {
            var vm = App.Locator.RecipeListViewModel;
            vm.LoadRecipesByCategory(category);
            Application.Current.MainPage.Navigation.PushAsync(new RecipeListView { BindingContext = vm });
        }

        public void NavigateToRecipeDetails(Recipe recipe)
        {
            var vm = App.Locator.RecipeDetailsViewModel;
            vm.LoadRecipeDescription(recipe);
            Application.Current
                 .MainPage
                 .Navigation
                 .PushModalAsync(new RecipeDetails { BindingContext = vm });
        }
    }
}