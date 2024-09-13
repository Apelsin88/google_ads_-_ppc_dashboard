using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface ICustomReportService
    {
        Task<IEnumerable<CustomReport>> GetAllCustomReportsAsync();
        Task<CustomReport> GetCustomReportByIdAsync(int id);
        Task AddCustomReportAsync(CustomReport customReport);
        Task UpdateCustomReportAsync(CustomReport customReport);
        Task DeleteCustomReportAsync(int id);
    }
}
