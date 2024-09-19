using System.Collections.Generic;
using System.Threading.Tasks;
using Google_Ads___PPC_Dashboard.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Google_Ads___PPC_Dashboard.Services
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersAsync();
        Task<ApplicationUser?> GetApplicationUserByIdAsync(string id);
        Task AddApplicationUserAsync(ApplicationUser user);
       //Task AddApplicationUserAsync(string id, string username, string email, string passwordHash, string firstName, string lastName, bool isActive, DateTime createdAt, DateTime updatedAt, DateTime lastLogin );
        Task UpdateApplicationUserAsync(ApplicationUser user);
        Task DeleteApplicationUserAsync(string id);
    }
}