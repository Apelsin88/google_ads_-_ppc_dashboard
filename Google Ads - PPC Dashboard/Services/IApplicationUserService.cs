using System.Collections.Generic;
using System.Threading.Tasks;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersAsync();
        Task<ApplicationUser?> GetApplicationUserByIdAsync(string id);
        Task AddApplicationUserAsync(ApplicationUser user);
        Task UpdateApplicationUserAsync(ApplicationUser user);
        Task DeleteApplicationUserAsync(string id);
    }
}