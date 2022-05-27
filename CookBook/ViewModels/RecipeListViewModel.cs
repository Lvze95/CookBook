using CookBook.DataAccess;
using CookBook.Models;
using CookBook.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

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

            OpenRecipeDetails = new Command(OnOpenRecipeDetails);
        }
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand OpenRecipeDetails { get; }

        public ObservableCollection<RecipeItemViewModel> RecipesSource
        {
            get => _recipes;
            set
            {
                _recipes = value;
                OnPropertyChanged(nameof(RecipesSource));
            }
        }

        public RecipeItemViewModel SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                _selectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }
         public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public void LoadRecipesByCategory(string category)
        {
            var listOfRecipesViewModel = new List<RecipeItemViewModel>();
            var listOfRecipes = _cookBookRepository.GetRecipesByCategory(category);

            Title = category;

            foreach (var Recipe in listOfRecipes)
            {
                listOfRecipesViewModel.Add(new RecipeItemViewModel(Recipe.Name, Recipe.ShortDescription, Recipe.ThumbnailImage));
            }

            RecipesSource = new ObservableCollection<RecipeItemViewModel>(listOfRecipesViewModel);
        }

        private void OnOpenRecipeDetails()
        {
            if (SelectedRecipe != null)
            {
                _navigationService.NavigateToRecipeDetails(SelectedRecipe);
            }
            SelectedRecipe = null;
        }

    }
}