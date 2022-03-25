using CookBook.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        private string _labelText;


        public MainViewModel(INavigationService navigation)
        {
            _navigationService = navigation;
            _labelText = "Let's test this :D";

            BreakfastClicked = new Command(OnBreakfastClicked);
        }

        public ICommand BreakfastClicked { get; }

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
        private void OnBreakfastClicked()
        {
            _navigationService.NavigateToTestPage();
        }

    }
}
