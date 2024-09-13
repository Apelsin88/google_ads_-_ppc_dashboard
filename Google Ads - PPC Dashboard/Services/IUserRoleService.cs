using System.Collections.Generic;
using System.Threading.Tasks;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IUserRoleService
    {
        Task<IEnumerable<UserRole>> GetAllUserRolesAsync();
        Task<UserRole?> GetUserRoleAsync(string userId, string roleId);
        Task AddUserRoleAsync(UserRole userRole);
        Task DeleteUserRoleAsync(string userId, string roleId);
    }
}