using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void onpropertychanged(string propertyname = null)
        //{
        //    propertychanged?.invoke(this,
        //        new propertychangedeventargs(propertyname)); 
        //} Pokusao sam ad napisem navigazij uza settings, Lazar

    }
}
