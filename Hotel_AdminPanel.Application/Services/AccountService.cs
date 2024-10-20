using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Application.ViewModels;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Hotel_AdminPanel.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ApplicationDbContext _context;


        public AccountService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IHttpContextAccessor contextAccessor, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _contextAccessor = contextAccessor;
            _context = context;
        }

        public async Task<List<AppUser>> GetAllUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            return users;
        }

        public Task<AppUser> GetCurrentUserAsync()
        {
            var currentUser = _contextAccessor.HttpContext.User;
            if (currentUser != null)
            {
                return _userManager.GetUserAsync(currentUser);
            }
            return null;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);

            return result;

        }


        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();

        }


        public async Task<IdentityResult> RegisterAsync(RegisterViewModel model)
        {
            // Ověř, zda uživatel s daným e-mailem již existuje
            var findUser = await _userManager.FindByEmailAsync(model.Email);
            if (findUser != null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User with this email already exists" });
            }

            // Vytvoř nového uživatele
            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PersonalIdentificationNumber = model.PersonalIdentificationNumber,
                PlaceOfBirth = model.PlaceOfBirth,
                ProfilePicture = model.ProfilePicture,
                InsuranceCompanyId = model.InsuranceCompanyId,
            };

            // Vytvoření uživatele
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // Zkontroluj, zda role 'User' existuje, pokud ne, vytvoř ji
                var userRole = await _roleManager.FindByNameAsync("User");
                if (userRole == null)
                {
                    userRole = new IdentityRole("User");
                    var roleResult = await _roleManager.CreateAsync(userRole);
                    if (!roleResult.Succeeded)
                    {
                        return IdentityResult.Failed(new IdentityError { Description = "Failed to create User role" });
                    }
                }

                // Přiřaď uživateli roli 'User'
                var addToRoleResult = await _userManager.AddToRoleAsync(user, "User");
                if (addToRoleResult.Succeeded)
                {
                    return IdentityResult.Success;
                }
                else
                {
                    // Pokud přiřazení role selže, smaž uživatele
                    await _userManager.DeleteAsync(user);
                    return IdentityResult.Failed(new IdentityError { Description = "Failed to assign User role" });
                }
            }

            return IdentityResult.Failed(new IdentityError { Description = "User creation failed" });

        }

        public async Task<IdentityResult> UpdateUserProfileAsync(AppUser model)
        {
            var user = await GetCurrentUserAsync();

            if (user != null)
            {
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.UserName = model.UserName;

                var updateResult = await _userManager.UpdateAsync(user);
                return updateResult;


            }
            return IdentityResult.Failed(new IdentityError { Description = "User not found" });
        }
    }
}

