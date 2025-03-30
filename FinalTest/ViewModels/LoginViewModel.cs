using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FinalTest.Services;

namespace FinalTest.ViewModel {
    public partial class LoginViewModel : ObservableObject {

        private readonly IMyFxBookApiService _apiService;

        public LoginViewModel(IMyFxBookApiService apiService) {
            _apiService = apiService;
            System.Diagnostics.Debug.WriteLine("LoginViewModel constructed");
        }

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        [ObservableProperty]
        string errorMessage;

        [RelayCommand]
        async Task LoginAsync() {
            try {
                System.Diagnostics.Debug.WriteLine("LoginAsync triggered");
                var session = await _apiService.LoginAsync(Email, Password);
                System.Diagnostics.Debug.WriteLine($"Session: {session}");
            } catch (Exception exception) {
                ErrorMessage = exception.Message;
                System.Diagnostics.Debug.WriteLine($"Error: {exception.Message}");
            }
        }
    }
}
