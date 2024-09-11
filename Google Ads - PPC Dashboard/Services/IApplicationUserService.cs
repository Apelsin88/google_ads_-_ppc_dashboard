using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersAsync();
        Task<ApplicationUser> GetApplicationUserByIdAsync(int id);
        Task AddApplicationUserAsync(ApplicationUser applicationUser);
        Task UpdateApplicationUserAsync(ApplicationUser applicationUser);
        Task DeleteApplicationUser(int id);
    }
}
