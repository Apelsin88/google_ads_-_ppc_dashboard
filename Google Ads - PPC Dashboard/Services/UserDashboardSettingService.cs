using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class UserDashboardSettingService : IUserDashboardSettingService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public UserDashboardSettingService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserDashboardSetting>> GetAllSettingsAsync()
        {
            return await _dbContext.UserDashboardSettings
                .Include(uds => uds.User)
                .ToListAsync();
        }

        public async Task<UserDashboardSetting> GetSettingByIdAsync(int id)
        {
            return await _dbContext.UserDashboardSettings
                .Include(uds => uds.User)
                .FirstOrDefaultAsync(uds => uds.Id! == id);
        }

        public async Task AddSettingAsync(UserDashboardSetting setting)
        {
            await _dbContext.UserDashboardSettings.AddAsync(setting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateSettingAsync(UserDashboardSetting setting)
        {
            _dbContext.UserDashboardSettings.Update(setting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSettingAsync(int id)
        {
            var setting = await _dbContext.UserDashboardSettings.FindAsync(id);
            if (setting != null)
            {
                _dbContext.UserDashboardSettings.Remove(setting);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
