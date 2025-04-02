using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W12D3C1.Model;
using W12D3C1.Services;

namespace W12D3C1.ViewModel {
    public partial class MonkeysViewModel : BaseViewModel{
        MonkeyService monkeyService;
        IConnectivity connectivity;

        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public MonkeysViewModel(MonkeyService monkeyService, IConnectivity connectivity) {
            this.monkeyService = monkeyService;
            this.connectivity = connectivity;
            Title = "Monkey Finder App";
        }

        [RelayCommand]
        async Task GetMonkeysAsync() {
            if (IsBusy) return;
            try {
                if(connectivity.NetworkAccess != NetworkAccess.Internet) {
                    await Shell.Current.DisplayAlert("Internet Issue!", "Check your internet connection.", "Ok");
                    return;
                }
                IsBusy = true;

                var monkeys = await monkeyService.GetMonkeys();

                if(Monkeys.Count != 0) {
                    Monkeys.Clear();
                }
                foreach(var monkey in monkeys) { Monkeys.Add(monkey); }
            }catch(Exception exception) {
                Debug.WriteLine(exception.Message); // debug does not execute in release
            } finally {
                IsBusy = false;
            }
        }
    }
}
