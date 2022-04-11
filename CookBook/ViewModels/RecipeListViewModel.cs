using CookBook.DataAccess;
using CookBook.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CookBook.ViewModels
{
    internal class RecipeListViewModel : BaseViewModel
    {
        private string _title;
        private readonly INavigationService _navigationService;

        private readonly ICookBookRepository _cookBookRepository;
        private ObservableCollection<RecipeItemViewModel> _recipes;
        private RecipeItemViewModel _selectedRecipe;

        public RecipeListViewModel(ICookBookRepository cookBookRepository, INavigationService navigationService)
        {
            _cookBookRepository = cookBookRepository;
            _navigationService = navigationService;
        }

        public ObservableCollection<RecipeItemViewModel> RecipesSource
        {
            get => _recipes;
            set
            {
                _recipes = value;
                OnPropertyChanged(nameof(RecipesSource));
            }
        }

        internal void LoadRecipesByCategory(string category)
        {
            var listOfRecipesViewModel = new List<RecipeItemViewModel>();
            var listOfRecipes = _cookBookRepository.GetRecipesByCategory(category);

            foreach (var Recipe in listOfRecipes)
            {
                listOfRecipesViewModel.Add(new RecipeItemViewModel(Recipe.Name, Recipe.ShortDescription, Recipe.ThumbnailImage));
            }

            RecipesSource = new ObservableCollection<RecipeItemViewModel>(listOfRecipesViewModel);
        }
    }
}