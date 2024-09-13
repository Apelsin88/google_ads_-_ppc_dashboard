using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class ConversionGoalService : IConversionGoalService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public ConversionGoalService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ConversionGoal>> GetAllConversionGoalsAsync()
        {
            return await _dbContext.ConversionGoals.ToListAsync();
        }

        public async Task<ConversionGoal?> GetConversionGoalByIdAsync(int id)
        {
            return await _dbContext.ConversionGoals.FindAsync(id);
        }

        public async Task AddConversionGoalAsync(ConversionGoal conversionGoal)
        {
            await _dbContext.ConversionGoals.AddAsync(conversionGoal);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateConversionGoalAsync(ConversionGoal conversionGoal)
        {
            _dbContext.ConversionGoals.Update(conversionGoal);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteConversionGoalAsync(int id)
        {
            var conversionGoal = await _dbContext.ConversionGoals.FindAsync(id);
            if (conversionGoal != null)
            {
                _dbContext.ConversionGoals.Remove(conversionGoal);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
