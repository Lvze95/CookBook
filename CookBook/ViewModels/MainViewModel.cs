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

        private readonly INavigationService _navigationService;

        private string _labelText;

        public MainViewModel(INavigationService navigation)
        {
            _navigationService = navigation;
            _labelText = "Let's test this :D";

            BreakfastClicked = new Command(OnBreakfastClicked);
            LunchClicked = new Command(OnLunchClicked);
            DinnerClicked = new Command(OnDinnerClicked);
            SnacksClicked = new Command(OnSnacksClicked);
        }

        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand BreakfastClicked { get; }
        public ICommand LunchClicked { get; }
        public ICommand DinnerClicked { get; }
        public ICommand SnacksClicked { get; }


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
            _navigationService.NavigateToBreakfast();
        }

        private void OnLunchClicked()
        {
            _navigationService.NavigateToLunch();
        }

        private void OnDinnerClicked()
        {
            _navigationService.NavigateToDinner();
        }

        private void OnSnacksClicked()
        {
            _navigationService.NavigateToSnacks();
        }
    }
}
