using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class CustomReportService : ICustomReportService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public CustomReportService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CustomReport>> GetAllCustomReportsAsync()
        {
            return await _dbContext.CustomReports
                .Include(cr => cr.User)
                .ToListAsync();
        }

        public async Task<CustomReport> GetCustomReportByIdAsync(int id)
        {
            return await _dbContext.CustomReports
                .Include(cr => cr.User)
                .FirstOrDefaultAsync(cr => cr.Id == id);
        }

        public async Task AddCustomReportAsync(CustomReport customReport)
        {
            await _dbContext.CustomReports.AddAsync(customReport);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCustomReportAsync(CustomReport customReport)
        {
            _dbContext.CustomReports.Update(customReport);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCustomReportAsync(int id)
        {
            var customReport = await _dbContext.CustomReports.FindAsync(id);
            if (customReport != null)
            {
                _dbContext.CustomReports.Remove(customReport);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
