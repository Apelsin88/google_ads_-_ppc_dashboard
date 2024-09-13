using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class CampaignPerformanceService : ICampaignPerformanceService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public CampaignPerformanceService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CampaignPerformance>> GetAllPerformancesAsync()
        {
            return await _dbContext.CampaignPerformances
                .Include(cp => cp.Campaign)
                .ToListAsync();
        }

        public async Task<CampaignPerformance> GetPerformanceByIdAsync(int id)
        {
            return await _dbContext.CampaignPerformances
                .Include(cp => cp.Campaign)
                .FirstOrDefaultAsync(cp => cp.Id == id);
        }

        public async Task AddPerformanceAsync(CampaignPerformance performance)
        {
            await _dbContext.CampaignPerformances.AddAsync(performance);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdatePerformanceAsync(CampaignPerformance performance)
        {
            _dbContext.CampaignPerformances.Update(performance);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePerformanceAsync(int id)
        {
            var performance = await _dbContext.CampaignPerformances.FindAsync(id);
            if (performance != null)
            {
                _dbContext.CampaignPerformances.Remove(performance);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
