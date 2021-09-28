using System;
using System.Collections.Generic;
using ParksApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParksApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            BindingContext = new TestViewModel();

            var testLabel1 = new Label() { Text = "Hello and welocme to the test page" };
            var testLabel2 = new Label() { Text = "This is the second page" };

            Content = new StackLayout() { Padding = 30, Children = { testLabel1, testLabel2} } ;
            
        }
    }
}
