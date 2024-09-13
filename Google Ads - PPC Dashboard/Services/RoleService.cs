using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Data;

namespace Google_Ads___PPC_Dashboard.Services
{
    public class RoleService : IRoleService
    {
        private readonly Google_Ads___PPC_DashboardContext _dbContext;

        public RoleService(Google_Ads___PPC_DashboardContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _dbContext.Roles
                .Include(r => r.UserRoles)
                .ThenInclude(ur => ur.User)
                .ToListAsync();
        }

        public async Task<Role?> GetRoleByIdAsync(string id)
        {
            return await _dbContext.Roles
                .Include(r => r.UserRoles)
                .ThenInclude(ur => ur.User)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task AddRoleAsync(Role role)
        {
            await _dbContext.Roles.AddAsync(role);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateRoleAsync(Role role)
        {
            _dbContext.Roles.Update(role);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(string id)
        {
            var role = await _dbContext.Roles.FindAsync(id);
            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
