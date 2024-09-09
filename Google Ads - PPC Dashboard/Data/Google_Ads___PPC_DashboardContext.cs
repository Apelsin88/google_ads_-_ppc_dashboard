using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Data
{
    public class Google_Ads___PPC_DashboardContext : DbContext
    {
        public Google_Ads___PPC_DashboardContext (DbContextOptions<Google_Ads___PPC_DashboardContext> options)
            : base(options)
        {
        }

        public DbSet<Google_Ads___PPC_Dashboard.Models.Ad> Ads { get; set; } = default!;
        public DbSet<Google_Ads___PPC_Dashboard.Models.AdGroup> AdGroups { get; set; } = default!;
        public DbSet<Google_Ads___PPC_Dashboard.Models.Campaign> Campaigns { get; set; } = default!;
        public DbSet<Google_Ads___PPC_Dashboard.Models.Budget> Budgets { get; set; } = default!;
        public DbSet<Google_Ads___PPC_Dashboard.Models.Keyword> Keywords { get; set; } = default!;
    }
}
