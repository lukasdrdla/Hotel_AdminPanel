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
        //DeleteUserAsync
        Task<IdentityResult> DeleteUserAsync(string Id);
        //GetUserByIdAsync
        Task<AppUser> GetUserByIdAsync(string Id);

        Task UpdateUserAsync(DetailUserViewModel model);
        Task<DetailUserViewModel> GetUserByEmailAsync(string email);


        Task<List<UserWithRolesViewModel>> GetAllUsersAsync();
        Task<IdentityResult> UpdateUserProfileAsync(AppUser model);

        // Role methods
        Task<IdentityResult> AddToRoleAsync(AppUser user, string roleName);
        Task<IdentityResult> RemoveFromRoleAsync(AppUser user, string roleName);
        Task<IList<string>> GetUserRolesAsync(AppUser user);
        //get all roles
        Task<List<IdentityRole>> GetAllRolesAsync();
        Task<IdentityResult> CreateRoleAsync(RoleViewModel model);
        Task<IdentityResult> UpdateRoleAsync(IdentityRole model);
        Task<IdentityResult> DeleteRoleAsync(string id);

        //insurance company methods
        Task<List<InsuranceCompany>> GetAllInsuranceCompaniesAsync();
    }
}
