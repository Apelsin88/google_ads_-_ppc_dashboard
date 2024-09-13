using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public UserRoleService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserRole>> GetAllUserRolesAsync()
        {
            return await _dbContext.UserRoles
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .ToListAsync();
        }

        public async Task<UserRole?> GetUserRoleAsync(string userId, string roleId)
        {
            return await _dbContext.UserRoles
                .Include(ur => ur.User)
                .Include(ur => ur.Role)
                .FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
        }

        public async Task AddUserRoleAsync(UserRole userRole)
        {
            await _dbContext.UserRoles.AddAsync(userRole);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserRoleAsync(string userId, string roleId)
        {
            var userRole = await _dbContext.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roleId);
            if (userRole != null)
            {
                _dbContext.UserRoles.Remove(userRole);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}