using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IAdGroupService
    {
        Task<IEnumerable<AdGroup>> GetAllAdGroupsAsync();
        Task<AdGroup?> GetAdGroupByIdAsync(int id);
        Task AddAdGroupAsync(AdGroup adGroup);
        Task UpdateAdGroupAsync(AdGroup adGroup);
        Task DeleteAdGroupAsync(int id);
    }
}
