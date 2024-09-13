using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IRefreshTokenService
    {
        Task<IEnumerable<RefreshToken>> GetAllRefreshTokensAsync();
        Task<RefreshToken> GetRefreshTokenByIdAsync(int id);
        Task AddRefreshTokenAsync(RefreshToken refreshToken);
        Task UpdateRefreshTokenAsync(RefreshToken refreshToken);
        Task DeleteRefreshTokenAsync(int id);
    }
}
