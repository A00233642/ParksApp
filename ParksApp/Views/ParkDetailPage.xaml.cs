using ParksApp.Models;
using Xamarin.Forms.Xaml;

using Xamarin.Forms;
using ParksApp.Services;

namespace ParksApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ParkId), nameof(ParkId))]

    public partial class ParkDetailPage : ContentPage
    {
        public string ParkId { get; set; }

        public IParkDataStore<Park> ParkDataSource => DependencyService.Get<IParkDataStore<Park>>();



        public ParkDetailPage()
        {
            InitializeComponent();
        }

        protected override async  void OnAppearing()
        {
            base.OnAppearing();
            // int.TryParse(ParkId, out var parkId);
            int.TryParse(ParkId, out var parkId);

            BindingContext = await ParkDataSource.GetPark(parkId); 

        }
    }
}
