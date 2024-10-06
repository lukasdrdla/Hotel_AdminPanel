using Hotel_AdminPanel.Dto;
using Microsoft.AspNetCore.Identity;

namespace Hotel_AdminPanel.Services.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterViewModel model);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
    }
}
