using CookBook.DataAccess;
using CookBook.Models;
using CookBook.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CookBook.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        private string _id;
        private string _name;
        private string _backgroundImage;
        private string _thumbnailImage;
        private string _shortDescription;
        private string _longDescription;
        private string _type;

        private ObservableCollection<RecipeNameViewModel> _steps;
        private ObservableCollection<IngredientViewModel> _ingredients;
        private ICookBookRepository _recipeRepository;
        private INavigationService _navigationService;

        public RecipeDetailsViewModel(ICookBookRepository recipeRepository, INavigationService navigationService)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigationService;
        }

        public ICommand BackToRecipeListCommand
        {
            get;
            set;
        }

        public Recipe Recipe { get; }

        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string BackgroundImage
        {
            get => _backgroundImage;
            set
            {
                _backgroundImage = value;
                OnPropertyChanged(nameof(BackgroundImage));
            }
        }

        public string ThumbnailImage
        {
            get => _thumbnailImage;
            set
            {
                _thumbnailImage = value;
                OnPropertyChanged(nameof(ThumbnailImage));
            }
        }

        public string ShortDescription
        {
            get => _shortDescription;
            set
            {
                _shortDescription = value;
                OnPropertyChanged(nameof(ShortDescription));
            }
        }

        public string LongDescription
        {
            get => _longDescription;
            set
            {
                _longDescription = value;
                OnPropertyChanged(nameof(LongDescription));
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        public ObservableCollection<RecipeNameViewModel> Steps
        {
            get => _steps;
            set
            {
                _steps = value;
                OnPropertyChanged(nameof(Steps));
            }
        }

        public ObservableCollection<IngredientViewModel> Ingredients
        {
            get => _ingredients;
            set
            {
                _ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }

        internal void LoadRecipeDescription(Recipe recipe)
        {
            Id = recipe.Id;
            Name = recipe.Name;
            BackgroundImage = recipe.BackgroundImage;
            ThumbnailImage = recipe.ThumbnailImage;
            ShortDescription = recipe.ShortDescription;
            LongDescription = recipe.LongDescription;
            Type = recipe.Type;
            Steps = new ObservableCollection<RecipeNameViewModel>();
            Ingredients = new ObservableCollection<IngredientViewModel>();
        }
    }
}