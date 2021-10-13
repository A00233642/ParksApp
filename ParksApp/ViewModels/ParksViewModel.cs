using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ParksApp.Models;
using Xamarin.CommunityToolkit.ObjectModel;

namespace ParksApp.ViewModels
{
    public class ParksViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Park> Parks { get; set; }
        public AsyncCommand RefreshCommand { get; }

        public ParksViewModel()
        {
            Title = "Parks";

            Parks = new ObservableRangeCollection<Park>();

            LoadParks();

            RefreshCommand = new AsyncCommand(Refresh);
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
