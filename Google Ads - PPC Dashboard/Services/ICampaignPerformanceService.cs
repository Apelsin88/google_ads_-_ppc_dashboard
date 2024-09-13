using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface ICampaignPerformanceService
    {
        Task<IEnumerable<CampaignPerformance>> GetAllPerformancesAsync();
        Task<CampaignPerformance> GetPerformanceByIdAsync(int id);
        Task AddPerformanceAsync(CampaignPerformance performance);
        Task UpdatePerformanceAsync(CampaignPerformance performance);
        Task DeletePerformanceAsync(int id);
    }
}
