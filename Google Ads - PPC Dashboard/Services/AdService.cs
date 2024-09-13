using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class AdService : IAdService
    {
        Google_Ads___PPC_DashboardContext DbContext;

        public AdService(Google_Ads___PPC_DashboardContext dbContext)
        {
            dbContext = DbContext;
        }

        public async Task<Ad> GetAdByIdAsync(int id)
        {
            return await DbContext.Ads.FindAsync(id);
        }

        public async Task<IEnumerable<Ad>> GetAllAdsAsync()
        {
            return await DbContext.Ads.ToListAsync();
        }

        public async Task AddAdAsync(Ad ad)
        {
            await DbContext.Ads.AddAsync(ad);
            await DbContext.SaveChangesAsync();
        }

        public async Task UpdateAdAsync(Ad ad)
        {
            DbContext.Ads.Update(ad);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAdAsync(int id)
        {
            var ad = await DbContext.Ads.FindAsync(id);
            if (ad != null)
            {
                DbContext.Ads.Remove(ad);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
