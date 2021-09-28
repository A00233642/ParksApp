using ParksApp.ViewModels;
using Xamarin.Forms;

namespace ParksApp.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomeViewModel();



            var learnMoreButton = new Button() { Text = "LEARN MORE", };
            learnMoreButton.SetBinding(Button.CommandProperty, new Binding("OpenWebCommand"));

            var testPageButton = new Button() { Text = "Go to TestPage" };
            testPageButton.SetBinding(Button.CommandProperty, new Binding("GoToTestPageCommand"));

            //var testPageButton = new Button() { Text = "Go to TestPage" };

            Content = new StackLayout() { Padding = 30, Children =
                {
                    learnMoreButton
                    , testPageButton

                }};

        }
    }
}
