using System;
using MvvmHelpers;
using ParksApp.Models;
using ParksApp.Services;
using Xamarin.Forms;

namespace ParksApp.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        public IParkDataStore<Park> ParkDataStore => DependencyService.Get<IParkDataStore<Park>>();


    }
}
