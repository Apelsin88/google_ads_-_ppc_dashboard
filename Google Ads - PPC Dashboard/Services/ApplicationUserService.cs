using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using System.Reflection.Metadata;
using Google.Api;
using Microsoft.AspNetCore.Identity;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public ApplicationUserService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersAsync()
        {
            return await _dbContext.ApplicationUsers
                .Include(u => u.CustomReports)
                .Include(u => u.UserDashboardSettings)
                .Include(u => u.RefreshTokens)
                .Include(u => u.UserRoles)
                .ToListAsync();
        }

        public async Task<ApplicationUser?> GetApplicationUserByIdAsync(string id)
        {
            return await _dbContext.ApplicationUsers
                .Include(u => u.CustomReports)
                .Include(u => u.UserDashboardSettings)
                .Include(u => u.RefreshTokens)
                .Include(u => u.UserRoles)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        //////////////Alternativ 1 /////////////////////////
        public async Task AddApplicationUserAsync(ApplicationUser user)
        {

            string password = "123321";
            //var passwordHash = HashPasswod(password);

            Parameter e = new Parameter();
            

            ///////////////////////////////////////////////////////////////////////////////////////////
            //Here?
            var roleService = new RoleService(_dbContext);
            string roleName = "Admin";
            //roleService.AssignRoleAsync(user.Id, user.Username, user.Email, user.PasswordHash, user.FirstName, user.LastName, user.IsActive, user.CreatedAt, user.UpdatedAt, user.LastLogin);

            await _dbContext.ApplicationUsers.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            await roleService.AssignRoleAsync(user, roleName);
        }


        //////////////Alternativ 2 /////////////////////////
        public async Task<ApplicationUser> CreateUserAsync(string username, string email, string password, params string[] roleNames)
        {
            // Hash the password (ensure you use a secure hashing algorithm)
            //var passwordHash = HashPassword(password);

            var user = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                Username = username,
                Email = email,
                //PasswordHash = passwordHash,
                PasswordHash = password,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
                // Set other properties as needed
            };

            // Assign roles to the user
            foreach (var roleName in roleNames)
            {
                var role = await _dbContext.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
                if (role != null)
                {
                    var userRole = new UserRole
                    {
                        UserId = user.Id,
                        RoleId = role.Id,
                        User = user,
                        Role = role
                    };
                    user.UserRoles.Add(userRole);
                }
                else
                {
                    // Handle the case where the role does not exist
                    throw new Exception($"Role '{roleName}' not found.");
                }
            }

            // Add the user to the context and save changes
            _dbContext.ApplicationUsers.Add(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task UpdateApplicationUserAsync(ApplicationUser user)
        {
            _dbContext.ApplicationUsers.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteApplicationUserAsync(string id)
        {
            var user = await _dbContext.ApplicationUsers.FindAsync(id);
            if (user != null)
            {
                _dbContext.ApplicationUsers.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}