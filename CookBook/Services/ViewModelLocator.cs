using CookBook.ViewModels;
using CookBook.Views;
using System;
using Xamarin.Forms.Xaml;

namespace CookBook.Services
{
    internal class ViewModelLocator
    {
        private readonly IServiceProvider _serviceProvider;

        public ViewModelLocator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public MainViewModel MainViewModel
            => _serviceProvider.GetService<MainViewModel>();

        public RecipeListViewModel RecipeListViewModel
            => _serviceProvider.GetService<RecipeListViewModel>();

    }
}
