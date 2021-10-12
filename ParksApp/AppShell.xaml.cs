using System;
using Xamarin.Forms;


namespace ParksApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
          //  Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
      
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
          
        }
    }
}
