using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public RefreshTokenService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<RefreshToken>> GetAllRefreshTokensAsync()
        {
            return await _dbContext.RefreshTokens
                .Include(rt => rt.User)
                .ToListAsync();
        }

        public async Task<RefreshToken> GetRefreshTokenByIdAsync(int id)
        {
            return await _dbContext.RefreshTokens
                .Include(rt => rt.User)
                .FirstOrDefaultAsync(rt => rt.Id == id);
        }

        public async Task AddRefreshTokenAsync(RefreshToken refreshToken)
        {
            await _dbContext.RefreshTokens.AddAsync(refreshToken);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateRefreshTokenAsync(RefreshToken refreshToken)
        {
            _dbContext.RefreshTokens.Update(refreshToken);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteRefreshTokenAsync(int id)
        {
            var refreshToken = await _dbContext.RefreshTokens.FindAsync(id);
            if (refreshToken != null)
            {
                _dbContext.RefreshTokens.Remove(refreshToken);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
