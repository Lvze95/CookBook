using CookBook.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CookBook.DataAccess
{
    internal class CookBookRepository : ICookBookRepository
    {
        private List<Recipe> _recipes = new List<Recipe>();
        private const string RecipeName = "Resources.recipe.json";

        public CookBookRepository()
        {
            LoadRecipes();
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipes;
        }

        public IEnumerable<string> GetAllRecipeCategories() //TO DO LIQU maybe? try to get from JSON file only recipe categories
        {
            return null;
        }

        private void LoadRecipes()
        {
            var assembly = typeof(CookBookRepository).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{RecipeName}");

            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var data = JsonConvert.DeserializeObject<Root>(json);
                _recipes = data.Recipe;
            }
        }
    }
}