using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Services
{
    internal interface INavigationService
    {
        void NavigateToBreakfast();
        void NavigateToLunch();
        void NavigateToDinner();
        void NavigateToSnacks();

    }
}
