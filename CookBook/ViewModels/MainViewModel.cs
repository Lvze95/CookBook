using CookBook.DataAccess;
using CookBook.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private Dictionary<string, string> _typeImageMap = new Dictionary<string, string>()
        {
            {"Breakfast", "dorucak.jpg" },
            {"Lunch", "rucak.jpg" },
            {"Sneaks", "keks.jpg" },
            {"Dinner", "vecera" },
        };

        private readonly INavigationService _navigationService;
        private readonly ICookBookRepository _cookBookRepository;

        private ObservableCollection<MealsCategoryViewModel> _categorySource;

        public MainViewModel(INavigationService navigation, ICookBookRepository recipeRepository)
        {
            _navigationService = navigation;
            _cookBookRepository = recipeRepository;

            LoadRecipes();

            OpenListOfMeals = new Command<string>(OnSelectedOpenListOfMeals);
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

        private void OnSelectedOpenListOfMeals(string obj)
        {
            throw new NotImplementedException();
        }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public ICommand OpenListOfMeals { get; }

        private void OnDinnerClicked()
        {
            _navigationService.NavigateToDinner();
        }

        private ImageSource image;

        public ImageSource Image { get => image; set => SetProperty(ref image, value); }

        private void SetProperty(ref ImageSource image, ImageSource value)
        {
            throw new NotImplementedException();
        }

        private string type;

        public string Type { get => type; set => SetProperty(ref type, value); }

        private void SetProperty(ref string type, string value)
        {
            throw new NotImplementedException();
        }
    }
}