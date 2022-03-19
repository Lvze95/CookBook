using System;
using System.Collections.Generic;
using System.Text;


namespace CookBook.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private string _labelText;

        public MainViewModel()
        {
            _labelText = "Let's test this :D";
        }

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

    }
}
