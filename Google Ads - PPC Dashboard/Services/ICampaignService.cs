using System.Collections.Generic;
using System.Threading.Tasks;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface ICampaignService
    {
        Task<IEnumerable<Campaign>> GetAllCampaignsAsync();
        Task<Campaign?> GetCampaignByIdAsync(int id);
        Task AddCampaignAsync(Campaign campaign);
        Task UpdateCampaignAsync(Campaign campaign);
        Task DeleteCampaignAsync(int id);
    }
}