using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class KeywordService : IKeywordService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public KeywordService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Keyword>> GetAllKeywordsAsync()
        {
            return await _dbContext.Keywords
                .Include(k => k.AdGroup)
                .ToListAsync();
        }

        public async Task<Keyword> GetKeywordByIdAsync(int id)
        {
            return await _dbContext.Keywords
                .Include(k => k.AdGroup)
                .FirstOrDefaultAsync(k => k.Id == id);
        }

        public async Task AddKeywordAsync(Keyword keyword)
        {
            await _dbContext.Keywords.AddAsync(keyword);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateKeywordAsync(Keyword keyword)
        {
            _dbContext.Keywords.Update(keyword);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteKeywordAsync(int id)
        {
            var keyword = await _dbContext.Keywords.FindAsync(id);
            if (keyword != null)
            {
                _dbContext.Keywords.Remove(keyword);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
