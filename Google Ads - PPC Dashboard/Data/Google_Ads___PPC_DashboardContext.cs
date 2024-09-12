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

            base.OnModelCreating(modelBuilder);

            // Seed Campaign Data
            modelBuilder.Entity<Campaign>().HasData(
                new Campaign { Id = 1, GoogleCampaignId = "GC001", Name = "Summer Sale", Status = "Active", Budget = 5000, BudgetType = "Daily", StartDate = DateTime.Now.AddMonths(-1), CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Campaign { Id = 2, GoogleCampaignId = "GC002", Name = "Winter Sale", Status = "Paused", Budget = 3000, BudgetType = "Monthly", StartDate = DateTime.Now.AddMonths(-2), CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            // Seed AdGroup Data
            modelBuilder.Entity<AdGroup>().HasData(
                new AdGroup { Id = 1, CampaignId = 1, Name = "Discount Ads", Status = "Enabled", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new AdGroup { Id = 2, CampaignId = 2, Name = "Holiday Ads", Status = "Paused", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            // Seed Ad Data
            modelBuilder.Entity<Ad>().HasData(
                new Ad { Id = 1, GoogleAdId = "AD001", AdGroupId = 1, AdType = "Text", HeadlinePart1 = "Huge Discounts", HeadlinePart2 = "Shop Now", Description1 = "Save up to 50%", FinalUrl = "https://example.com", Status = "Active", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Ad { Id = 2, GoogleAdId = "AD002", AdGroupId = 2, AdType = "Display", HeadlinePart1 = "Winter Special", HeadlinePart2 = "Limited Time Offer", Description1 = "Don't Miss Out", FinalUrl = "https://example.com", Status = "Paused", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            // Seed ApplicationUser Data
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = "1", Username = "john.doe", Email = "john.doe@example.com", PasswordHash = "hashedpassword1", FirstName = "John", LastName = "Doe", IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, LastLogin = DateTime.Now },
                new ApplicationUser { Id = "2", Username = "jane.smith", Email = "jane.smith@example.com", PasswordHash = "hashedpassword2", FirstName = "Jane", LastName = "Smith", IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, LastLogin = DateTime.Now.AddDays(-1) },
                new ApplicationUser { Id = "3", Username = "mike.jones", Email = "mike.jones@example.com", PasswordHash = "hashedpassword3", FirstName = "Mike", LastName = "Jones", IsActive = false, CreatedAt = DateTime.Now.AddMonths(-1), UpdatedAt = DateTime.Now.AddMonths(-1), LastLogin = DateTime.Now.AddDays(-10) },
                new ApplicationUser { Id = "4", Username = "emma.brown", Email = "emma.brown@example.com", PasswordHash = "hashedpassword4", FirstName = "Emma", LastName = "Brown", IsActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, LastLogin = DateTime.Now.AddDays(-5) }
            );
        }

    }
}
