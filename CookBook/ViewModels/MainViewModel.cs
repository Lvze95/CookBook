using CookBook.DataAccess;
using CookBook.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ICookBookRepository _cookBookRepository;

        private ObservableCollection<MealsCategoryViewModel> _categorySource;
        private MealsCategoryViewModel _selectedRecipeCategory;

        public MainViewModel(INavigationService navigation, ICookBookRepository recipeRepository)
        {
            _navigationService = navigation;
            _cookBookRepository = recipeRepository;

            LoadRecipes();

            OpenListOfMeals = new Command(OnOpenListOfMeals);
        }

        private void LoadRecipes()
        {
            var mealsViewModel = new List<MealsCategoryViewModel>();
            var categories = _cookBookRepository.GetAllRecipeCategories();

            foreach (var category in categories)
            {
                var categoryImage = _cookBookRepository.GetCategoryImageName(category);

                mealsViewModel.Add(new MealsCategoryViewModel(category, categoryImage));
            }

            CategorySource = new ObservableCollection<MealsCategoryViewModel>(mealsViewModel);
        }

        public ObservableCollection<MealsCategoryViewModel> CategorySource
        {
            get { return _categorySource; }
            set
            {
                _categorySource = value;
                OnPropertyChanged(nameof(CategorySource));
            }
        }

        public MealsCategoryViewModel SelectedRecipeCategory
        {
            get { return _selectedRecipeCategory; }
            set
            {
                _selectedRecipeCategory = value;
                OnPropertyChanged(nameof(SelectedRecipeCategory));
            }
        }

        private void OnOpenListOfMeals()
        {
            if (SelectedRecipeCategory != null)
            {
                _navigationService.NavigateToListOfMeals(SelectedRecipeCategory.Type);
            }
            SelectedRecipeCategory = null;
        }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public ICommand OpenListOfMeals { get; }
    }
}