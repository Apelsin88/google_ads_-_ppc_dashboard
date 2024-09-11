using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
namespace Google_Ads___PPC_Dashboard.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        Google_Ads___PPC_DashboardContext DbContext;

        public ApplicationUserService(Google_Ads___PPC_DashboardContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllApplicationUsersAsync()
        {
            return await DbContext.ApplicationUsers.ToListAsync();
        }

        public async Task<ApplicationUser> GetApplicationUserByIdAsync(int id)
        {
            return await DbContext.ApplicationUsers.FindAsync(id);
        }

        public async Task AddApplicationUserAsync(ApplicationUser applicationUser)
        {
            DbContext.ApplicationUsers.Add(applicationUser);
            await DbContext.SaveChangesAsync();
        }

        public async Task UpdateApplicationUserAsync(ApplicationUser applicationUser)
        {
            DbContext.ApplicationUsers.Update(applicationUser);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteApplicationUser(int id)
        {
            var applicationUser = await DbContext.ApplicationUsers.FindAsync(id);
            if (applicationUser != null)
            {
                DbContext.ApplicationUsers.Remove(applicationUser);
                await DbContext.SaveChangesAsync();
            }
        }
    }
}
