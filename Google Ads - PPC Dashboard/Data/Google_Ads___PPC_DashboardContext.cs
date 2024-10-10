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

            //// Seed-data for CampaignPerformance
            //modelBuilder.Entity<CampaignPerformance>().HasData(
            //    // Campaign 1 Performance Data
            //    Enumerable.Range(1, 30).Select(i => new CampaignPerformance(i, 1, currentDate.AddDays(-i),
            //        impressions: 1000 + i * 10,
            //        clicks: 50 + i,
            //        cost: 500m + i * 10,
            //        conversions: 10 + i,
            //        conversionValue: 1000m + i * 50)).ToArray(),

            //    // Campaign 2 Performance Data
            //    Enumerable.Range(31, 30).Select(i => new CampaignPerformance(i, 2, currentDate.AddDays(-(i - 30)),
            //        impressions: 900 + i * 8,
            //        clicks: 40 + i,
            //        cost: 400m + i * 8,
            //        conversions: 8 + i,
            //        conversionValue: 800m + i * 40)).ToArray(),

            //    // Campaign 3 Performance Data
            //    Enumerable.Range(61, 30).Select(i => new CampaignPerformance(i, 3, currentDate.AddDays(-(i - 60)),
            //        impressions: 2000 + i * 20,
            //        clicks: 100 + i * 2,
            //        cost: 1000m + i * 20,
            //        conversions: 20 + i,
            //        conversionValue: 2000m + i * 100)).ToArray(),

            //    // Campaign 4 Performance Data
            //    Enumerable.Range(91, 30).Select(i => new CampaignPerformance(i, 4, currentDate.AddDays(-(i - 90)),
            //        impressions: 500 + i * 5,
            //        clicks: 25 + i,
            //        cost: 250m + i * 5,
            //        conversions: 5 + i,
            //        conversionValue: 500m + i * 25)).ToArray(),

            //    // Campaign 5 Performance Data
            //    Enumerable.Range(121, 30).Select(i => new CampaignPerformance(i, 5, currentDate.AddDays(-(i - 120)),
            //        impressions: 1500 + i * 15,
            //        clicks: 75 + i,
            //        cost: 750m + i * 15,
            //        conversions: 15 + i,
            //        conversionValue: 1500m + i * 75)).ToArray()
            //);

            modelBuilder.Entity<CampaignPerformance>().HasData(
    // Campaign 1 Performance Data
    new CampaignPerformance(1, 1, currentDate.AddDays(-30), 1000, 50, 500m, 10, 1000m),
    new CampaignPerformance(2, 1, currentDate.AddDays(-29), 1050, 52, 525m, 11, 1050m),
    new CampaignPerformance(3, 1, currentDate.AddDays(-28), 1100, 54, 550m, 12, 1100m),
    new CampaignPerformance(4, 1, currentDate.AddDays(-27), 1150, 56, 575m, 13, 1150m),
    new CampaignPerformance(5, 1, currentDate.AddDays(-26), 1200, 58, 600m, 14, 1200m),
    new CampaignPerformance(6, 1, currentDate.AddDays(-25), 1250, 60, 625m, 15, 1250m),
    new CampaignPerformance(7, 1, currentDate.AddDays(-24), 1300, 62, 650m, 16, 1300m),
    new CampaignPerformance(8, 1, currentDate.AddDays(-23), 1350, 64, 675m, 17, 1350m),
    new CampaignPerformance(9, 1, currentDate.AddDays(-22), 1400, 66, 700m, 18, 1400m),
    new CampaignPerformance(10, 1, currentDate.AddDays(-21), 1450, 68, 725m, 19, 1450m),
    new CampaignPerformance(11, 1, currentDate.AddDays(-20), 1500, 70, 750m, 20, 1500m),
    new CampaignPerformance(12, 1, currentDate.AddDays(-19), 1550, 72, 775m, 21, 1550m),
    new CampaignPerformance(13, 1, currentDate.AddDays(-18), 1600, 74, 800m, 22, 1600m),
    new CampaignPerformance(14, 1, currentDate.AddDays(-17), 1650, 76, 825m, 23, 1650m),
    new CampaignPerformance(15, 1, currentDate.AddDays(-16), 1700, 78, 850m, 24, 1700m),
    new CampaignPerformance(16, 1, currentDate.AddDays(-15), 1750, 80, 875m, 25, 1750m),
    new CampaignPerformance(17, 1, currentDate.AddDays(-14), 1800, 82, 900m, 26, 1800m),
    new CampaignPerformance(18, 1, currentDate.AddDays(-13), 1850, 84, 925m, 27, 1850m),
    new CampaignPerformance(19, 1, currentDate.AddDays(-12), 1900, 86, 950m, 28, 1900m),
    new CampaignPerformance(20, 1, currentDate.AddDays(-11), 1950, 88, 975m, 29, 1950m),
    new CampaignPerformance(21, 1, currentDate.AddDays(-10), 2000, 90, 1000m, 30, 2000m),
    new CampaignPerformance(22, 1, currentDate.AddDays(-9), 2050, 92, 1025m, 31, 2050m),
    new CampaignPerformance(23, 1, currentDate.AddDays(-8), 2100, 94, 1050m, 32, 2100m),
    new CampaignPerformance(24, 1, currentDate.AddDays(-7), 2150, 96, 1075m, 33, 2150m),
    new CampaignPerformance(25, 1, currentDate.AddDays(-6), 2200, 98, 1100m, 34, 2200m),
    new CampaignPerformance(26, 1, currentDate.AddDays(-5), 2250, 100, 1125m, 35, 2250m),
    new CampaignPerformance(27, 1, currentDate.AddDays(-4), 2300, 102, 1150m, 36, 2300m),
    new CampaignPerformance(28, 1, currentDate.AddDays(-3), 2350, 104, 1175m, 37, 2350m),
    new CampaignPerformance(29, 1, currentDate.AddDays(-2), 2400, 106, 1200m, 38, 2400m),
    new CampaignPerformance(30, 1, currentDate.AddDays(-1), 2450, 108, 1225m, 39, 2450m),

    // Campaign 2 Performance Data
    new CampaignPerformance(31, 2, currentDate.AddDays(-30), 900, 45, 450m, 9, 900m),
    new CampaignPerformance(32, 2, currentDate.AddDays(-29), 950, 47, 475m, 10, 950m),
    new CampaignPerformance(33, 2, currentDate.AddDays(-28), 1000, 49, 500m, 11, 1000m),
    new CampaignPerformance(34, 2, currentDate.AddDays(-27), 1050, 51, 525m, 12, 1050m),
    new CampaignPerformance(35, 2, currentDate.AddDays(-26), 1100, 53, 550m, 13, 1100m),
    new CampaignPerformance(36, 2, currentDate.AddDays(-25), 1150, 55, 575m, 14, 1150m),
    new CampaignPerformance(37, 2, currentDate.AddDays(-24), 1200, 57, 600m, 15, 1200m),
    new CampaignPerformance(38, 2, currentDate.AddDays(-23), 1250, 59, 625m, 16, 1250m),
    new CampaignPerformance(39, 2, currentDate.AddDays(-22), 1300, 61, 650m, 17, 1300m),
    new CampaignPerformance(40, 2, currentDate.AddDays(-21), 1350, 63, 675m, 18, 1350m),
    new CampaignPerformance(41, 2, currentDate.AddDays(-20), 1400, 65, 700m, 19, 1400m),
    new CampaignPerformance(42, 2, currentDate.AddDays(-19), 1450, 67, 725m, 20, 1450m),
    new CampaignPerformance(43, 2, currentDate.AddDays(-18), 1500, 69, 750m, 21, 1500m),
    new CampaignPerformance(44, 2, currentDate.AddDays(-17), 1550, 71, 775m, 22, 1550m),
    new CampaignPerformance(45, 2, currentDate.AddDays(-16), 1600, 73, 800m, 23, 1600m),
    new CampaignPerformance(46, 2, currentDate.AddDays(-15), 1650, 75, 825m, 24, 1650m),
    new CampaignPerformance(47, 2, currentDate.AddDays(-14), 1700, 77, 850m, 25, 1700m),
    new CampaignPerformance(48, 2, currentDate.AddDays(-13), 1750, 79, 875m, 26, 1750m),
    new CampaignPerformance(49, 2, currentDate.AddDays(-12), 1800, 81, 900m, 27, 1800m),
    new CampaignPerformance(50, 2, currentDate.AddDays(-11), 1850, 83, 925m, 28, 1850m),
    new CampaignPerformance(51, 2, currentDate.AddDays(-10), 1900, 85, 950m, 29, 1900m),
    new CampaignPerformance(52, 2, currentDate.AddDays(-9), 1950, 87, 975m, 30, 1950m),
    new CampaignPerformance(53, 2, currentDate.AddDays(-8), 2000, 89, 1000m, 31, 2000m),
    new CampaignPerformance(54, 2, currentDate.AddDays(-7), 2050, 91, 1025m, 32, 2050m),
    new CampaignPerformance(55, 2, currentDate.AddDays(-6), 2100, 93, 1050m, 33, 2100m),
    new CampaignPerformance(56, 2, currentDate.AddDays(-5), 2150, 95, 1075m, 34, 2150m),
    new CampaignPerformance(57, 2, currentDate.AddDays(-4), 2200, 97, 1100m, 35, 2200m),
    new CampaignPerformance(58, 2, currentDate.AddDays(-3), 2250, 99, 1125m, 36, 2250m),
    new CampaignPerformance(59, 2, currentDate.AddDays(-2), 2300, 101, 1150m, 37, 2300m),
    new CampaignPerformance(60, 2, currentDate.AddDays(-1), 2350, 103, 1175m, 38, 2350m),

    // Campaign 3 Performance Data
    new CampaignPerformance(61, 3, currentDate.AddDays(-30), 2000, 100, 1000m, 20, 2000m),
    new CampaignPerformance(62, 3, currentDate.AddDays(-29), 2050, 102, 1025m, 21, 2050m),
    new CampaignPerformance(63, 3, currentDate.AddDays(-28), 2100, 104, 1050m, 22, 2100m),
    new CampaignPerformance(64, 3, currentDate.AddDays(-27), 2150, 106, 1075m, 23, 2150m),
    new CampaignPerformance(65, 3, currentDate.AddDays(-26), 2200, 108, 1100m, 24, 2200m),
    new CampaignPerformance(66, 3, currentDate.AddDays(-25), 2250, 110, 1125m, 25, 2250m),
    new CampaignPerformance(67, 3, currentDate.AddDays(-24), 2300, 112, 1150m, 26, 2300m),
    new CampaignPerformance(68, 3, currentDate.AddDays(-23), 2350, 114, 1175m, 27, 2350m),
    new CampaignPerformance(69, 3, currentDate.AddDays(-22), 2400, 116, 1200m, 28, 2400m),
    new CampaignPerformance(70, 3, currentDate.AddDays(-21), 2450, 118, 1225m, 29, 2450m),
    new CampaignPerformance(71, 3, currentDate.AddDays(-20), 2500, 120, 1250m, 30, 2500m),
    new CampaignPerformance(72, 3, currentDate.AddDays(-19), 2550, 122, 1275m, 31, 2550m),
    new CampaignPerformance(73, 3, currentDate.AddDays(-18), 2600, 124, 1300m, 32, 2600m),
    new CampaignPerformance(74, 3, currentDate.AddDays(-17), 2650, 126, 1325m, 33, 2650m),
    new CampaignPerformance(75, 3, currentDate.AddDays(-16), 2700, 128, 1350m, 34, 2700m),
    new CampaignPerformance(76, 3, currentDate.AddDays(-15), 2750, 130, 1375m, 35, 2750m),
    new CampaignPerformance(77, 3, currentDate.AddDays(-14), 2800, 132, 1400m, 36, 2800m),
    new CampaignPerformance(78, 3, currentDate.AddDays(-13), 2850, 134, 1425m, 37, 2850m),
    new CampaignPerformance(79, 3, currentDate.AddDays(-12), 2900, 136, 1450m, 38, 2900m),
    new CampaignPerformance(80, 3, currentDate.AddDays(-11), 2950, 138, 1475m, 39, 2950m),
    new CampaignPerformance(81, 3, currentDate.AddDays(-10), 3000, 140, 1500m, 40, 3000m),
    new CampaignPerformance(82, 3, currentDate.AddDays(-9), 3050, 142, 1525m, 41, 3050m),
    new CampaignPerformance(83, 3, currentDate.AddDays(-8), 3100, 144, 1550m, 42, 3100m),
    new CampaignPerformance(84, 3, currentDate.AddDays(-7), 3150, 146, 1575m, 43, 3150m),
    new CampaignPerformance(85, 3, currentDate.AddDays(-6), 3200, 148, 1600m, 44, 3200m),
    new CampaignPerformance(86, 3, currentDate.AddDays(-5), 3250, 150, 1625m, 45, 3250m),
    new CampaignPerformance(87, 3, currentDate.AddDays(-4), 3300, 152, 1650m, 46, 3300m),
    new CampaignPerformance(88, 3, currentDate.AddDays(-3), 3350, 154, 1675m, 47, 3350m),
    new CampaignPerformance(89, 3, currentDate.AddDays(-2), 3400, 156, 1700m, 48, 3400m),
    new CampaignPerformance(90, 3, currentDate.AddDays(-1), 3450, 158, 1725m, 49, 3450m),

    // Campaign 4 Performance Data
    new CampaignPerformance(91, 4, currentDate.AddDays(-30), 500, 25, 250m, 5, 500m),
    new CampaignPerformance(92, 4, currentDate.AddDays(-29), 550, 28, 280m, 6, 550m),
    new CampaignPerformance(93, 4, currentDate.AddDays(-28), 600, 30, 300m, 7, 600m),
    new CampaignPerformance(94, 4, currentDate.AddDays(-27), 650, 32, 320m, 8, 650m),
    new CampaignPerformance(95, 4, currentDate.AddDays(-26), 700, 35, 350m, 9, 700m),
    new CampaignPerformance(96, 4, currentDate.AddDays(-25), 750, 37, 375m, 10, 750m),
    new CampaignPerformance(97, 4, currentDate.AddDays(-24), 800, 40, 400m, 11, 800m),
    new CampaignPerformance(98, 4, currentDate.AddDays(-23), 850, 42, 425m, 12, 850m),
    new CampaignPerformance(99, 4, currentDate.AddDays(-22), 900, 45, 450m, 13, 900m),
    new CampaignPerformance(100, 4, currentDate.AddDays(-21), 950, 48, 475m, 14, 950m),
    new CampaignPerformance(101, 4, currentDate.AddDays(-20), 1000, 50, 500m, 15, 1000m),
    new CampaignPerformance(102, 4, currentDate.AddDays(-19), 1050, 52, 525m, 16, 1050m),
    new CampaignPerformance(103, 4, currentDate.AddDays(-18), 1100, 54, 550m, 17, 1100m),
    new CampaignPerformance(104, 4, currentDate.AddDays(-17), 1150, 56, 575m, 18, 1150m),
    new CampaignPerformance(105, 4, currentDate.AddDays(-16), 1200, 58, 600m, 19, 1200m),
    new CampaignPerformance(106, 4, currentDate.AddDays(-15), 1250, 60, 625m, 20, 1250m),
    new CampaignPerformance(107, 4, currentDate.AddDays(-14), 1300, 62, 650m, 21, 1300m),
    new CampaignPerformance(108, 4, currentDate.AddDays(-13), 1350, 64, 675m, 22, 1350m),
    new CampaignPerformance(109, 4, currentDate.AddDays(-12), 1400, 66, 700m, 23, 1400m),
    new CampaignPerformance(110, 4, currentDate.AddDays(-11), 1450, 68, 725m, 24, 1450m),
    new CampaignPerformance(111, 4, currentDate.AddDays(-10), 1500, 70, 750m, 25, 1500m),
    new CampaignPerformance(112, 4, currentDate.AddDays(-9), 1550, 72, 775m, 26, 1550m),
    new CampaignPerformance(113, 4, currentDate.AddDays(-8), 1600, 74, 800m, 27, 1600m),
    new CampaignPerformance(114, 4, currentDate.AddDays(-7), 1650, 76, 825m, 28, 1650m),
    new CampaignPerformance(115, 4, currentDate.AddDays(-6), 1700, 78, 850m, 29, 1700m),
    new CampaignPerformance(116, 4, currentDate.AddDays(-5), 1750, 80, 875m, 30, 1750m),
    new CampaignPerformance(117, 4, currentDate.AddDays(-4), 1800, 82, 900m, 31, 1800m),
    new CampaignPerformance(118, 4, currentDate.AddDays(-3), 1850, 84, 925m, 32, 1850m),
    new CampaignPerformance(119, 4, currentDate.AddDays(-2), 1900, 86, 950m, 33, 1900m),
    new CampaignPerformance(120, 4, currentDate.AddDays(-1), 1950, 88, 975m, 34, 1950m),

    // Campaign 5 Performance Data
    new CampaignPerformance(121, 5, currentDate.AddDays(-30), 3000, 150, 1500m, 30, 3000m),
    new CampaignPerformance(122, 5, currentDate.AddDays(-29), 3100, 155, 1550m, 31, 3100m),
    new CampaignPerformance(123, 5, currentDate.AddDays(-28), 3200, 160, 1600m, 32, 3200m),
    new CampaignPerformance(124, 5, currentDate.AddDays(-27), 3300, 165, 1650m, 33, 3300m),
    new CampaignPerformance(125, 5, currentDate.AddDays(-26), 3400, 170, 1700m, 34, 3400m),
    new CampaignPerformance(126, 5, currentDate.AddDays(-25), 3500, 175, 1750m, 35, 3500m),
    new CampaignPerformance(127, 5, currentDate.AddDays(-24), 3600, 180, 1800m, 36, 3600m),
    new CampaignPerformance(128, 5, currentDate.AddDays(-23), 3700, 185, 1850m, 37, 3700m),
    new CampaignPerformance(129, 5, currentDate.AddDays(-22), 3800, 190, 1900m, 38, 3800m),
    new CampaignPerformance(130, 5, currentDate.AddDays(-21), 3900, 195, 1950m, 39, 3900m),
    new CampaignPerformance(131, 5, currentDate.AddDays(-20), 4000, 200, 2000m, 40, 4000m),
    new CampaignPerformance(132, 5, currentDate.AddDays(-19), 4100, 205, 2050m, 41, 4100m),
    new CampaignPerformance(133, 5, currentDate.AddDays(-18), 4200, 210, 2100m, 42, 4200m),
    new CampaignPerformance(134, 5, currentDate.AddDays(-17), 4300, 215, 2150m, 43, 4300m),
    new CampaignPerformance(135, 5, currentDate.AddDays(-16), 4400, 220, 2200m, 44, 4400m),
    new CampaignPerformance(136, 5, currentDate.AddDays(-15), 4500, 225, 2250m, 45, 4500m),
    new CampaignPerformance(137, 5, currentDate.AddDays(-14), 4600, 230, 2300m, 46, 4600m),
    new CampaignPerformance(138, 5, currentDate.AddDays(-13), 4700, 235, 2350m, 47, 4700m),
    new CampaignPerformance(139, 5, currentDate.AddDays(-12), 4800, 240, 2400m, 48, 4800m),
    new CampaignPerformance(140, 5, currentDate.AddDays(-11), 4900, 245, 2450m, 49, 4900m),
    new CampaignPerformance(141, 5, currentDate.AddDays(-10), 5000, 250, 2500m, 50, 5000m),
    new CampaignPerformance(142, 5, currentDate.AddDays(-9), 5100, 255, 2550m, 51, 5100m),
    new CampaignPerformance(143, 5, currentDate.AddDays(-8), 5200, 260, 2600m, 52, 5200m),
    new CampaignPerformance(144, 5, currentDate.AddDays(-7), 5300, 265, 2650m, 53, 5300m),
    new CampaignPerformance(145, 5, currentDate.AddDays(-6), 5400, 270, 2700m, 54, 5400m),
    new CampaignPerformance(146, 5, currentDate.AddDays(-5), 5500, 275, 2750m, 55, 5500m),
    new CampaignPerformance(147, 5, currentDate.AddDays(-4), 5600, 280, 2800m, 56, 5600m),
    new CampaignPerformance(148, 5, currentDate.AddDays(-3), 5700, 285, 2850m, 57, 5700m),
    new CampaignPerformance(149, 5, currentDate.AddDays(-2), 5800, 290, 2900m, 58, 5800m),
    new CampaignPerformance(150, 5, currentDate.AddDays(-1), 5900, 295, 2950m, 59, 5900m)
    );



        // Seed-data for CampaignPerformance
        //var campaignPerformances = new List<CampaignPerformance>();

        //// Create 30 performance records for each of the 5 campaigns
        //for (int campaignId = 1; campaignId <= 5; campaignId++)
        //{
        //    for (int i = 1; i <= 30; i++)
        //    {
        //        var performance = new CampaignPerformance
        //        {
        //            // The Id will be auto-generated
        //            CampaignId = campaignId,
        //            Date = currentDate.AddDays(-i),
        //            Impressions = 1000 + i * 10 * campaignId,  // Example calculation for impressions
        //            Clicks = 50 + i * campaignId,              // Example calculation for clicks
        //            Cost = 500m + i * 10 * campaignId,        // Example calculation for cost
        //            Conversions = 10 + i * campaignId,         // Example calculation for conversions
        //            ConversionValue = 1000m + i * 50 * campaignId // Example calculation for conversion value
        //        };
        //        campaignPerformances.Add(performance);
        //    }
        //}

        //modelBuilder.Entity<CampaignPerformance>().HasData(campaignPerformances.ToArray());
    }
}
}
