using CookBook.Models;
using System.Collections.Generic;

namespace CookBook.DataAccess
{
    internal interface ICookBookRepository
    {
        IEnumerable<Recipe> GetAllRecipes();

        IEnumerable<string> GetAllRecipeCategories();

        string GetCategoryImageName(string categoryName);

        IEnumerable<Recipe> GetRecipeByCategory(string categoryName);
    }
}