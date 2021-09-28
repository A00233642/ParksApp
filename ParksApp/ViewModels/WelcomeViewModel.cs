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

            var park = new Models.Park();
            park.Id = 1;
            park.name = "RedPark";
            
            park.Description1 = "This is an awesome part";

            park.Amenities.Add(new Models.Park.Amenity() { Type = Models.Park.Amenity.Types.Swings,Quantity = 1, Description = "Blue swing set for ages 3 to 7." });

            park.Amenities.Add(new Models.Park.Amenity() { Type = Models.Park.Amenity.Types.Swings,Quantity = 1, Description = "Green swing set for ages 3 to 7." });


        }

        public ICommand OpenWebCommand { get; }
        public ICommand GoToTestPageCommand { get; }
    }
}