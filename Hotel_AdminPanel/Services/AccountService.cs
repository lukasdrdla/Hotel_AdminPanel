using Hotel_AdminPanel.Dto;
using Hotel_AdminPanel.Models;
using Hotel_AdminPanel.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Hotel_AdminPanel.Services
{
    public class AccountService : IAccountService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            var findUser = await _userManager.FindByEmailAsync(model.Email);
            if (findUser != null)
            {
                var result = await _signInManager.CanSignInAsync(findUser);
                if (result)
                {
                    var signInResult = await _signInManager.PasswordSignInAsync(findUser, model.Password, false, false);
                    if (signInResult.Succeeded)
                    {
                        return SignInResult.Success;
                    }
                }
            }



            return SignInResult.Failed;
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> RegisterAsync(RegisterViewModel model)
        {
            var findUser = await _userManager.FindByEmailAsync(model.Email);
            if (findUser != null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User with this email already exists" });
            }

            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var adminRole = await _roleManager.FindByNameAsync("Admin");
                if (adminRole == null)
                {
                    adminRole = new IdentityRole("Admin");
                    await _roleManager.CreateAsync(adminRole);
                }
                else
                {
                    var userRole = await _roleManager.FindByNameAsync("User");
                    if (userRole == null)
                    {
                        userRole = new IdentityRole("User");
                        await _roleManager.CreateAsync(userRole);
                    }
                }

                return IdentityResult.Success;



            }
            return IdentityResult.Failed(new IdentityError { Description = "User creation failed" });

        }
    }
}
