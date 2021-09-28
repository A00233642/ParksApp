using System;
using System.Windows.Input;
using ParksApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ParksApp.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
        {
            Title = "Welcome to the application";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.google.com"));
            GoToTestPageCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(TestPage)));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand GoToTestPageCommand { get; }
    }
}
