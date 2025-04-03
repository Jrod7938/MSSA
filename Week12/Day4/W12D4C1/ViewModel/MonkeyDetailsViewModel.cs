using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W12D3C1.Model;

namespace W12D3C1.ViewModel {
    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeyDetailsViewModel : BaseViewModel {
        IMap map;

        public MonkeyDetailsViewModel(IMap map) {
            this.map = map;
        }

        [ObservableProperty]
        Monkey monkey;

        [RelayCommand]
        async Task OpenMapAsync() {
            try {
                await map.TryOpenAsync(Monkey.Latitude, Monkey.Longitude, new MapLaunchOptions { Name=Monkey.Name, NavigationMode=NavigationMode.Driving});
            } catch (Exception exception) {
                Debug.WriteLine($"Error: {exception.Message}");
                await Shell.Current.DisplayAlert("Error", "Unable To Open Map", "Ok");
            }
        }
    }
}
