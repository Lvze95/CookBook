using CookBook.DataAccess;
using CookBook.Services;
using System;
using System.Collections.Generic;
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

        public MainViewModel(INavigationService navigation, ICookBookRepository recipeRepository)
        {
            _navigationService = navigation;
            _cookBookRepository = recipeRepository;

            LoadRecipes();

            OpenListOfMeals = new Command<string>(OnSelectedOpenListOfMeals);
        }

        public void LoadRecipes()
        {
            var mainViewModel = new List<MainViewModel>();
            var categories = _cookBookRepository.GetAllRecipeCategories();

            /* foreach (var category in categories)
             {
                 mainViewModel.Add(new MainViewModel())
             }

             var notesViewModel = new List<NoteItemViewModel>();
             var notes = _notesRepository.GetAllNotes();

             foreach (var note in notes)
             {
                 notesViewModel.Add(new NoteItemViewModel(note));
             }

             NotesSource = new ObservableCollection<NoteItemViewModel>(notesViewModel); */
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
    }
}