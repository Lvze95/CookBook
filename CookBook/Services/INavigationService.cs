using CookBook.ViewModels;

namespace CookBook.Services
{
    internal interface INavigationService
    {
        void NavigateToListOfMeals(string category);

        void NavigateToRecipeDetails(RecipeItemViewModel recipe);
    }
}