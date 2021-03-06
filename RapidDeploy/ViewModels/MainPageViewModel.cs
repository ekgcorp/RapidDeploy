using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;

namespace RapidDeploy.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MapPartViewModel MapPartViewModel { get; } = new MapPartViewModel();
        public SearchPartViewModel SearchPartViewModel { get; } = new SearchPartViewModel();

        string _Value = "Gas";
        string Value { get { return _Value; } set { Set(ref _Value, value); } }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
                Value = suspensionState[nameof(Value)]?.ToString();
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(Value)] = Value;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void GotoDetailsPage() =>
        NavigationService.Navigate(typeof(Views.DetailPage), Value);

        public void GotoMigrationPage() =>
        NavigationService.Navigate(typeof(Views.MigrationPage), Value);

        public void GotoSettings() =>
        NavigationService.Navigate(typeof(Views.SettingsPage), 0);

        public void GotoPrivacy() =>
        NavigationService.Navigate(typeof(Views.SettingsPage), 1);

        public void GotoAbout() =>
        NavigationService.Navigate(typeof(Views.SettingsPage), 2);

    }

    public class MapPartViewModel : ViewModelBase
    {

    }


    public class SearchPartViewModel : ViewModelBase
    {
        private string Value;

        public SearchPartViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Value = "Property from MainPageVM.cs";
            }

        }

    }
}