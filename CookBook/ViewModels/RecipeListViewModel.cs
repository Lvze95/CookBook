using CookBook.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CookBook.ViewModels
{
    internal class RecipeListViewModel : BaseViewModel
    {
        internal void LoadRecipes(string category)
        {
            throw new NotImplementedException();
        }
        private string _title;
        private ICookBookRepository _cookBookRepository;
        private ObservableCollection<RecipeItemViewModel> _recipes;
        private RecipeItemViewModel _selectedRecipe;
    }
}
