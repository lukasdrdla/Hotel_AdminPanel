using Hotel_AdminPanel.Application.ViewModels;
using Hotel_AdminPanel.Domain.Entities;
using Microsoft.AspNetCore.Identity;


namespace Hotel_AdminPanel.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterViewModel model);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
        Task<AppUser> GetCurrentUserAsync();
        Task<IdentityResult> UpdateUserProfileAsync(AppUser model);
        Task<List<AppUser>> GetAllUsersAsync();
    }
}
