using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using W12D3C1.Model;
using W12D3C1.Services;
using W12D3C1.View;

namespace W12D3C1.ViewModel {
    public partial class MonkeysViewModel : BaseViewModel {
        MonkeyService monkeyService;
        IConnectivity connectivity;
        IGeolocation geolocation;

        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public MonkeysViewModel(MonkeyService monkeyService, IConnectivity connectivity, IGeolocation geolocation) {
            this.monkeyService = monkeyService;
            this.connectivity = connectivity;
            this.geolocation = geolocation;
            Title = "Monkey Finder App";
        }

        [RelayCommand]
        async Task GetMonkeysAsync() {
            if (IsBusy) return;
            try {
                if (connectivity.NetworkAccess != NetworkAccess.Internet) {
                    await Shell.Current.DisplayAlert("Internet Issue!", "Check your internet connection.", "Ok");
                    return;
                }
                IsBusy = true;

                var monkeys = await monkeyService.GetMonkeys();

                if (Monkeys.Count != 0) {
                    Monkeys.Clear();
                }
                foreach (var monkey in monkeys) { Monkeys.Add(monkey); }
            } catch (Exception exception) {
                Debug.WriteLine(exception.Message); // debug does not execute in release
            } finally {
                IsBusy = false;
            }
        }

        [RelayCommand]
        async Task GetClosestMonkey() {
            if (IsBusy || Monkeys.Count == 0) return;
            try {
                var location = await geolocation.GetLastKnownLocationAsync();
                if (location == null) {
                    location = await geolocation.GetLocationAsync(
                        new GeolocationRequest {
                            DesiredAccuracy = GeolocationAccuracy.Medium,
                            Timeout = TimeSpan.FromSeconds(30)
                        });
                }
                if (location == null) {
                    await Shell.Current.DisplayAlert("Location Issue", "Unable to get location.", "Ok");
                    return;
                }

                var first = Monkeys.OrderBy(x => location.CalculateDistance(x.Latitude, x.Longitude, DistanceUnits.Miles)).FirstOrDefault();

                if (first == null) return;
                await Shell.Current.DisplayAlert("Closest Monkey", $"{first.Name} at {first.Location}", "Ok");
                await GoToDetailAsync(first);

            } catch (Exception exception) {
                Debug.WriteLine(exception.Message);
                await Shell.Current.DisplayAlert("Error", "Unable to get closest monkey!", "Ok");
            }
        }

        async Task GoToDetailAsync(Monkey monkey) {
            if (monkey == null) return;
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, 
                new Dictionary<string, object> {
                    {"Monkey", monkey }
                });
        }
    }
}
