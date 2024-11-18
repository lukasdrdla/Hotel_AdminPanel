using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Application.ViewModels;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net;

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

        public Task<IdentityResult> AddToRoleAsync(AppUser user, string roleName)
        {
            throw new NotImplementedException();
        }


        public Task<IdentityResult> CreateRoleAsync(RoleViewModel model)
        {
            try
            {
                var role = new IdentityRole
                {
                    Name = model.Name
                };
                var result = _roleManager.CreateAsync(role).Result;
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError { Description = ex.Message }));
            }

        }

        public async Task<IdentityResult> DeleteRoleAsync(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Role not found" });
            }

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded) {
                return IdentityResult.Success;
            }
            return IdentityResult.Failed(new IdentityError { Description = "Failed to delete role" });

        }

        public async Task<IdentityResult> DeleteUserAsync(string Id)
        {
            var existingUser = await _userManager.FindByIdAsync(Id);
            if (existingUser == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            var result = await _userManager.DeleteAsync(existingUser);
            return result;
        }

        public async Task<List<InsuranceCompany>> GetAllInsuranceCompaniesAsync()
        {
            var insuranceCompanies = await _context.InsuranceCompanies.ToListAsync();
            return insuranceCompanies;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return roles;
        }

        public async Task<List<UserWithRolesViewModel>> GetAllUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var usersWithRoles = new List<UserWithRolesViewModel>();

            foreach (var user in users) {
                var roles = await _userManager.GetRolesAsync(user);
                var userWithRoles = new UserWithRolesViewModel
                {
                    User = user,
                    Roles = roles.ToList()
                };
                usersWithRoles.Add(userWithRoles);
            }

            return usersWithRoles;
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

        public async Task<DetailUserViewModel> GetUserByEmailAsync(string email)
        {
            var user = await _context.Users
                .Include(u => u.InsuranceCompany) //include
                .FirstOrDefaultAsync(u => u.Email == email);

            //include


            if (user == null)
            {
                return null;
            }

            var roles = await _userManager.GetRolesAsync(user);

            var model = new DetailUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                PersonalIdentificationNumber = user.PersonalIdentificationNumber,
                PlaceOfBirth = user.PlaceOfBirth,
                ProfilePicture = user.ProfilePicture,
                Address = user.Address,
                City = user.City,
                PostalCode = user.PostalCode,
                Country = user.Country,
                JobTitle = user.JobTitle,
                StartDate = user.StartDate,
                Salary = user.Salary,
                IsEmployed = user.IsEmployed,
                Role = roles.FirstOrDefault(),
                InsuranceCompanyId = user.InsuranceCompanyId

            };
            return model;
        }

        public async Task<AppUser> GetUserByIdAsync(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            return user;
        }

        public Task<IList<string>> GetUserRolesAsync(AppUser user)
        {
            throw new NotImplementedException();
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
                Address = model.Address,
                City = model.City,
                PostalCode = model.PostalCode,
                Country = model.Country,
                JobTitle = model.JobTitle,
                StartDate = model.StartDate,
                Salary = model.Salary,
                IsEmployed = model.IsEmployed,
                PhoneNumber = model.PhoneNumber

            };


            try
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(model.Role))
                    {
                        var roleResult = await _userManager.AddToRoleAsync(user, model.Role);

                        if (!roleResult.Succeeded)
                        {
                            return IdentityResult.Failed(new IdentityError { Description = "Failed to add user to role" });

                        }


                    }

                    return IdentityResult.Success;


                }
            }

            catch (Exception ex)
            {
                return IdentityResult.Failed(new IdentityError { Description = ex.Message });
            }
            return IdentityResult.Success;
        }

            public Task<IdentityResult> RemoveFromRoleAsync(AppUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> UpdateRoleAsync(IdentityRole model)
        {
            var existingRole = await _roleManager.FindByIdAsync(model.Id);
            if (existingRole == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "Role not found" });
            }

            existingRole.Name = model.Name;
            var updateResult = await _roleManager.UpdateAsync(existingRole);
            return updateResult;

        }

        public async Task UpdateUserAsync(DetailUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null) {
                throw new Exception("User not found");
            }


            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.PersonalIdentificationNumber = model.PersonalIdentificationNumber;
            user.PlaceOfBirth = model.PlaceOfBirth;
            user.ProfilePicture = model.ProfilePicture;
            user.Address = model.Address;
            user.City = model.City;
            user.PostalCode = model.PostalCode;
            user.Country = model.Country;
            user.JobTitle = model.JobTitle;
            user.StartDate = model.StartDate;
            user.Salary = model.Salary;
            user.IsEmployed = model.IsEmployed;
            user.InsuranceCompanyId = model.InsuranceCompanyId;

            //role
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.FirstOrDefault() != model.Role)
            {
                await _userManager.RemoveFromRolesAsync(user, roles);
                await _userManager.AddToRoleAsync(user, model.Role);
            }


            await _userManager.UpdateAsync(user);

        }

        public async Task<IdentityResult> UpdateUserProfileAsync(AppUser model)
        {
            var user = await GetCurrentUserAsync();

            if (user != null)
            {
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.UserName = model.UserName;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PersonalIdentificationNumber = model.PersonalIdentificationNumber;
                user.PlaceOfBirth = model.PlaceOfBirth;
                user.ProfilePicture = model.ProfilePicture;
                user.InsuranceCompanyId = model.InsuranceCompanyId;

                var updateResult = await _userManager.UpdateAsync(user);
                return updateResult;


            }
            return IdentityResult.Failed(new IdentityError { Description = "User not found" });
        }
    }
}

