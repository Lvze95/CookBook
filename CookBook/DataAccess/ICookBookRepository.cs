using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.DataAccess
{
    internal interface ICookBookRepository
    {
        IEnumerable<Recipe> GetAllRecipes();
        IEnumerable<string> GetAllRecipeCategories();
    }
}
