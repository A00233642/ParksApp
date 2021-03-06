using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ParksApp.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace ParksApp.ViewModels
{
    public class ParksViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Park> Parks { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand<Park> SelectedCommand { get;   }

        Park selectedPark;

        public Park SelectedPark
        {
            get => selectedPark;
            set => SetProperty(ref selectedPark, value);
        }

        public ParksViewModel()
        {
            Title = "Parks";

            Parks = new ObservableRangeCollection<Park>();

            LoadParks();

            RefreshCommand = new AsyncCommand(Refresh);
            SelectedCommand = new AsyncCommand<Park>(Selected);
        }

        async Task Selected(Park park)
        {
           // await Application.Current.MainPage.DisplayAlert("Selected", park.Name, "OK");

            string route = $"{nameof(Views.ParkDetailPage)}?ParkId ={park.Id}";
            await Shell.Current.GoToAsync(route);

        }

        private async Task Refresh()
        {
            IsBusy = true;

            Parks.Clear();
            LoadParks();

            IsBusy = false;
        }

        private async void LoadParks()
        {
            IEnumerable<Park> parks = await ParkDataStore.GetParks();
            Parks.AddRange(parks);  

        }
    }
}
