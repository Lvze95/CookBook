using CookBook.Models;

namespace CookBook.Services
{
    internal interface INavigationService
    {
        void NavigateToListOfMeals(string category);

        void NavigateToRecipeDetails(Recipe recipe);
    }
}