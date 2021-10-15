
using Xamarin.Forms;

namespace ParksApp.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

        }

        ListView HeaderList = new ListView()
        {

            Header = "Header",
        };
    }
}
