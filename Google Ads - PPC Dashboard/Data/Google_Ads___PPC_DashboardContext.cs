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

        public DbSet<Google_Ads___PPC_Dashboard.Models.ApplicationUser> ApplicationUsers { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.Campaign> Campaigns { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.CampaignPerformance> CampaignPerformances { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.ConversionGoal> ConversionGoals { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.CustomReport> CustomReports { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.Keyword> Keywords { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.RefreshToken> RefreshTokens { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.Role> Roles { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.UserDashboardSetting> UserDashboardSettings { get; set; } = default!;

        public DbSet<Google_Ads___PPC_Dashboard.Models.UserRole> UserRoles { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
        }

    }
}
