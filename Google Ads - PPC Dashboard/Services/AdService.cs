using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class AdService : IAdService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public AdService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Ad>> GetAllAdsAsync()
        {
            return await _dbContext.Ads
                .Include(a => a.AdGroup)
                .ToListAsync();
        }

        public async Task<Ad?> GetAdByIdAsync(int id)
        {
            return await _dbContext.Ads
            .Include(a => a.AdGroup)
            .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAdAsync(Ad ad)
        {
            await _dbContext.Ads.AddAsync(ad);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAdAsync(Ad ad)
        {
            _dbContext.Ads.Update(ad);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAdAsync(int id)
        {
            var ad = await _dbContext.Ads.FindAsync(id);
            if (ad != null)
            {
                _dbContext.Ads.Remove(ad);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
