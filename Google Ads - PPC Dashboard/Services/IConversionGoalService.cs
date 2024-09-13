using System.Collections.Generic;
using System.Threading.Tasks;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IConversionGoalService
    {
        Task<IEnumerable<ConversionGoal>> GetAllConversionGoalsAsync();
        Task<ConversionGoal?> GetConversionGoalByIdAsync(int id); // Ändrad returtyp
        Task AddConversionGoalAsync(ConversionGoal conversionGoal);
        Task UpdateConversionGoalAsync(ConversionGoal conversionGoal);
        Task DeleteConversionGoalAsync(int id);
    }
}
