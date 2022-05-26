using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.ViewModels
{
    internal class MealsCategoryViewModel : BaseViewModel
    {
        public MealsCategoryViewModel(string category, string image)
        {
            Type = category;
            Image = image;
        }
        public string Recipe { get; set; }
        public string Image { get; set; }
        private string _type;

        public string Type
        {
            get { return _type; }

            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }
    }
}
