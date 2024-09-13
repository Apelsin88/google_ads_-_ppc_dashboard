using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class AdGroupService : IAdGroupService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public AdGroupService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<AdGroup>> GetAllAdGroupsAsync()
        {
            return await _dbContext.AdGroups
                .Include(ag => ag.Campaign)
                .Include(ag => ag.Ads)
                .Include(ag => ag.Keywords)
                .ToListAsync();
        }

        public async Task<AdGroup?> GetAdGroupByIdAsync(int id)
{
    return await _dbContext.AdGroups
        .Include(ag => ag.Campaign)
        .Include(ag => ag.Ads)
        .Include(ag => ag.Keywords)
        .FirstOrDefaultAsync(ag => ag.Id == id);
}

        public async Task AddAdGroupAsync(AdGroup adGroup)
        {
            await _dbContext.AdGroups.AddAsync(adGroup);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAdGroupAsync(AdGroup adGroup)
        {
            _dbContext.AdGroups.Update(adGroup);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAdGroupAsync(int id)
        {
            var adGroup = await _dbContext.AdGroups.FindAsync(id);
            if (adGroup != null)
            {
                _dbContext.AdGroups.Remove(adGroup);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
