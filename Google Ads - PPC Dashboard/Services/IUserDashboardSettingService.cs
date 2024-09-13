using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IUserDashboardSettingService
    {
        Task<IEnumerable<UserDashboardSetting>> GetAllSettingsAsync();
        Task<UserDashboardSetting> GetSettingByIdAsync(int id);
        Task AddSettingAsync(UserDashboardSetting setting);
        Task UpdateSettingAsync(UserDashboardSetting setting);
        Task DeleteSettingAsync(int id);
    }
}
