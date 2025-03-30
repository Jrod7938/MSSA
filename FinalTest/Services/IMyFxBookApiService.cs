using FinalTest.Models;

namespace FinalTest.Services {
    public interface IMyFxBookApiService {
        Task<string> LoginAsync(string email, string password);
        Task LogoutAsync(string session);
        Task<List<Account>> GetAccountsAsync(string session);
    }
}
