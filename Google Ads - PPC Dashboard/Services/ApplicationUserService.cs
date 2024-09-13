using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;

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

        public async Task AddApplicationUserAsync(ApplicationUser user)
        {
            await _dbContext.ApplicationUsers.AddAsync(user);
            await _dbContext.SaveChangesAsync();
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