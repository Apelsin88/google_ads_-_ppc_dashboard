using System;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Data
{
    public class Google_Ads___PPC_DashboardContext : DbContext
    {
        public Google_Ads___PPC_DashboardContext(DbContextOptions<Google_Ads___PPC_DashboardContext> options)
            : base(options)
        {
        }

        // Definiera alla DbSets för dina entiteter
        public DbSet<Ad> Ads { get; set; } = default!;
        public DbSet<AdGroup> AdGroups { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;
        public DbSet<Campaign> Campaigns { get; set; } = default!;
        public DbSet<CampaignPerformance> CampaignPerformances { get; set; } = default!;
        public DbSet<ConversionGoal> ConversionGoals { get; set; } = default!;
        public DbSet<CustomReport> CustomReports { get; set; } = default!;
        public DbSet<Keyword> Keywords { get; set; } = default!;
        public DbSet<RefreshToken> RefreshTokens { get; set; } = default!;
        public DbSet<Role> Roles { get; set; } = default!;
        public DbSet<UserDashboardSetting> UserDashboardSettings { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; } = default!;

        // OnModelCreating metod för att konfigurera relationer och seed-data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfigurera sammansatt primärnyckel för UserRole
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            // Konfigurera relationer för UserRole
            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            // Anpassa datatyper för SQLite
            modelBuilder.Entity<AdGroup>(entity =>
            {
                entity.Property(e => e.GoogleAdGroup).HasColumnType("TEXT");
                entity.Property(e => e.Name).HasColumnType("TEXT");
                entity.Property(e => e.Status).HasColumnType("TEXT");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.Property(e => e.GoogleCampaignId).HasColumnType("TEXT");
                entity.Property(e => e.Name).HasColumnType("TEXT");
                entity.Property(e => e.Status).HasColumnType("TEXT");
            });

            // Seed-data för Campaign
            var currentDate = DateTime.UtcNow;
            modelBuilder.Entity<Campaign>().HasData(
                new Campaign
                {
                    Id = 1,
                    GoogleCampaignId = "GC001",
                    Name = "Summer Sale",
                    Status = "Active",
                    Budget = 5000,
                    BudgetType = "Daily",
                    StartDate = currentDate.AddMonths(-1),
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                },
                new Campaign
                {
                    Id = 2,
                    GoogleCampaignId = "GC002",
                    Name = "Winter Sale",
                    Status = "Paused",
                    Budget = 3000,
                    BudgetType = "Monthly",
                    StartDate = currentDate.AddMonths(-2),
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                }
            );

            // Seed-data för AdGroup
            modelBuilder.Entity<AdGroup>().HasData(
                new AdGroup
                {
                    Id = 1,
                    CampaignId = 1,
                    Name = "Discount Ads",
                    Status = "Enabled",
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                },
                new AdGroup
                {
                    Id = 2,
                    CampaignId = 2,
                    Name = "Holiday Ads",
                    Status = "Paused",
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                }
            );

            // Seed-data för Ads
            modelBuilder.Entity<Ad>().HasData(
                new Ad
                {
                    Id = 1,
                    GoogleAdId = "AD001",
                    AdGroupId = 1,
                    AdType = "Text",
                    HeadlinePart1 = "Huge Discounts",
                    HeadlinePart2 = "Shop Now",
                    Description1 = "Save up to 50%",
                    FinalUrl = "https://example.com",
                    Status = "Active",
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                },
                new Ad
                {
                    Id = 2,
                    GoogleAdId = "AD002",
                    AdGroupId = 2,
                    AdType = "Display",
                    HeadlinePart1 = "Winter Special",
                    HeadlinePart2 = "Limited Time Offer",
                    Description1 = "Don't Miss Out",
                    FinalUrl = "https://example.com",
                    Status = "Paused",
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate
                }
            );

            // Seed-data för ApplicationUsers
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "1",
                    Username = "john.doe",
                    Email = "john.doe@example.com",
                    PasswordHash = "hashedpassword1",
                    FirstName = "John",
                    LastName = "Doe",
                    IsActive = true,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    LastLogin = currentDate
                },
                new ApplicationUser
                {
                    Id = "2",
                    Username = "jane.smith",
                    Email = "jane.smith@example.com",
                    PasswordHash = "hashedpassword2",
                    FirstName = "Jane",
                    LastName = "Smith",
                    IsActive = true,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    LastLogin = currentDate.AddDays(-1)
                },
                new ApplicationUser
                {
                    Id = "3",
                    Username = "mike.jones",
                    Email = "mike.jones@example.com",
                    PasswordHash = "hashedpassword3",
                    FirstName = "Mike",
                    LastName = "Jones",
                    IsActive = false,
                    CreatedAt = currentDate.AddMonths(-1),
                    UpdatedAt = currentDate.AddMonths(-1),
                    LastLogin = currentDate.AddDays(-10)
                },
                new ApplicationUser
                {
                    Id = "4",
                    Username = "emma.brown",
                    Email = "emma.brown@example.com",
                    PasswordHash = "hashedpassword4",
                    FirstName = "Emma",
                    LastName = "Brown",
                    IsActive = true,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    LastLogin = currentDate.AddDays(-5)
                }
            );
        }
    }
}
