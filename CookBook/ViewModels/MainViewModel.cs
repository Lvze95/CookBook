using CookBook.Services;
using System;
using System.Collections.Generic;
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

        private string _labelText;

        public MainViewModel(INavigationService navigation)
        {
            _navigationService = navigation;
            _labelText = "Let's test this :D";

            OpenListOfMeals = new Command<string>(OnSelectedOpenListOfMeals);
        }

        private void OnSelectedOpenListOfMeals(string obj)
        {
            throw new NotImplementedException();
        }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public ICommand OpenListOfMeals { get; }


        public string LabelText 
        { 
            get 
            { 
                return _labelText; 
            } 
            set 
            { 
                _labelText = value; 
                OnPropertyChanged(nameof(LabelText));
            }
        }
        private void OnDinnerClicked()
        {
            _navigationService.NavigateToDinner();
        }
    }
}
