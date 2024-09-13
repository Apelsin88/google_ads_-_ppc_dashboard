using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IKeywordService
    {
        Task<IEnumerable<Keyword>> GetAllKeywordsAsync();
        Task<Keyword> GetKeywordByIdAsync(int id);
        Task AddKeywordAsync(Keyword keyword);
        Task UpdateKeywordAsync(Keyword keyword);
        Task DeleteKeywordAsync(int id);
    }
}
