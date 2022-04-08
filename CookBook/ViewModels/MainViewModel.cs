using CookBook.DataAccess;
using CookBook.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
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

        /*protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }*/

        private ImageSource image;

        public ImageSource Image { get => image; set => SetProperty(ref image, value); }

        private void SetProperty(ref ImageSource image, ImageSource value)
        {
            throw new NotImplementedException();
        }

        /*protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }*/

        private string type;

        public string Type { get => type; set => SetProperty(ref type, value); }

        private void SetProperty(ref string type, string value)
        {
            throw new NotImplementedException();
        }
    }
}