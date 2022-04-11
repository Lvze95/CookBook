﻿using CookBook.DataAccess;
using CookBook.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        private string _name;
        private string _backgroundImage;
        private string _longdescription;
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

        public string Longdescription
        {
            get => _longdescription;
            set
            {
                _longdescription = value;
                OnPropertyChanged(nameof(Longdescription));
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
    }
}