using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IAdService
    {
        Task<IEnumerable<Ad>> GetAllAdsAsync();
        Task<Ad?> GetAdByIdAsync(int id);
        Task AddAdAsync(Ad ad);
        Task UpdateAdAsync(Ad ad);
        Task DeleteAdAsync(int id);
    }
}
