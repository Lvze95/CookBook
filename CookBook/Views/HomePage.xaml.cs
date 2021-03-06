using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Light Mode", "Ok");
        }

        private void DisplayAlert(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            DisplayAlert("Dark Mode", "Ok");
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings()); //Navigacija za settings
        }
    }
}