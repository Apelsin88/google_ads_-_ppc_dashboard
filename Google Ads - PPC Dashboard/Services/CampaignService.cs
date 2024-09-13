using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public CampaignService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Campaign>> GetAllCampaignsAsync()
        {
            return await _dbContext.Campaigns
                .Include(c => c.AdGroups)
                .Include(c => c.Performances)
                .ToListAsync();
        }

        public async Task<Campaign?> GetCampaignByIdAsync(int id)
        {
            return await _dbContext.Campaigns
                .Include(c => c.AdGroups)
                .Include(c => c.Performances)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddCampaignAsync(Campaign campaign)
        {
            await _dbContext.Campaigns.AddAsync(campaign);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCampaignAsync(Campaign campaign)
        {
            _dbContext.Campaigns.Update(campaign);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCampaignAsync(int id)
        {
            var campaign = await _dbContext.Campaigns.FindAsync(id);
            if (campaign != null)
            {
                _dbContext.Campaigns.Remove(campaign);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}