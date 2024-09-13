﻿// <auto-generated />
using System;
using Google_Ads___PPC_Dashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Google_Ads___PPC_Dashboard.Migrations
{
    [DbContext(typeof(Google_Ads___PPC_DashboardContext))]
    partial class Google_Ads___PPC_DashboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Ad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FinalUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleAdId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadlinePart1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadlinePart2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdGroupId");

                    b.ToTable("Ads");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdGroupId = 1,
                            AdType = "Text",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Description1 = "Save up to 50%",
                            FinalUrl = "https://example.com",
                            GoogleAdId = "AD001",
                            HeadlinePart1 = "Huge Discounts",
                            HeadlinePart2 = "Shop Now",
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618)
                        },
                        new
                        {
                            Id = 2,
                            AdGroupId = 2,
                            AdType = "Display",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Description1 = "Don't Miss Out",
                            FinalUrl = "https://example.com",
                            GoogleAdId = "AD002",
                            HeadlinePart1 = "Winter Special",
                            HeadlinePart2 = "Limited Time Offer",
                            Status = "Paused",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618)
                        });
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.AdGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CampaignId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleAdGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("AdGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampaignId = 1,
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Name = "Discount Ads",
                            Status = "Enabled",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618)
                        },
                        new
                        {
                            Id = 2,
                            CampaignId = 2,
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Name = "Holiday Ads",
                            Status = "Paused",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618)
                        });
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            LastName = "Doe",
                            PasswordHash = "hashedpassword1",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Username = "john.doe"
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 12, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            LastName = "Smith",
                            PasswordHash = "hashedpassword2",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Username = "jane.smith"
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Email = "mike.jones@example.com",
                            FirstName = "Mike",
                            IsActive = false,
                            LastLogin = new DateTime(2024, 9, 3, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            LastName = "Jones",
                            PasswordHash = "hashedpassword3",
                            UpdatedAt = new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Username = "mike.jones"
                        },
                        new
                        {
                            Id = "4",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Email = "emma.brown@example.com",
                            FirstName = "Emma",
                            IsActive = true,
                            LastLogin = new DateTime(2024, 9, 8, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            LastName = "Brown",
                            PasswordHash = "hashedpassword4",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Username = "emma.brown"
                        });
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Budget")
                        .HasColumnType("TEXT");

                    b.Property<string>("BudgetType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleCampaignId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 5000m,
                            BudgetType = "Daily",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            GoogleCampaignId = "GC001",
                            Name = "Summer Sale",
                            StartDate = new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Status = "Active",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618)
                        },
                        new
                        {
                            Id = 2,
                            Budget = 3000m,
                            BudgetType = "Monthly",
                            CreatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            GoogleCampaignId = "GC002",
                            Name = "Winter Sale",
                            StartDate = new DateTime(2024, 7, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618),
                            Status = "Paused",
                            UpdatedAt = new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618)
                        });
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.CampaignPerformance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CampaignId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Clicks")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ConversionValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("Conversions")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Impressions")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("CampaignPerformances");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.ConversionGoal", b =>
                {
                    b.Property<int>("ConversionGoalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("ConversionGoalId");

                    b.ToTable("ConversionGoals");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.CustomReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Configuration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CustomReports");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Keyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Bid")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("GoogleKeywordId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KeywordText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MatchType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("QualityScore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdGroupId");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.UserDashboardSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WidgetPosition")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WidgetSettings")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WidgetType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDashboardSettings");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Ad", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.AdGroup", "AdGroup")
                        .WithMany("Ads")
                        .HasForeignKey("AdGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdGroup");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.AdGroup", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.Campaign", "Campaign")
                        .WithMany("AdGroups")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.CampaignPerformance", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.Campaign", "Campaign")
                        .WithMany("Performances")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.CustomReport", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.ApplicationUser", "User")
                        .WithMany("CustomReports")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Keyword", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.AdGroup", "AdGroup")
                        .WithMany("Keywords")
                        .HasForeignKey("AdGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdGroup");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.RefreshToken", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.ApplicationUser", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.UserDashboardSetting", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.ApplicationUser", "User")
                        .WithMany("UserDashboardSettings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.UserRole", b =>
                {
                    b.HasOne("Google_Ads___PPC_Dashboard.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Google_Ads___PPC_Dashboard.Models.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.AdGroup", b =>
                {
                    b.Navigation("Ads");

                    b.Navigation("Keywords");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.ApplicationUser", b =>
                {
                    b.Navigation("CustomReports");

                    b.Navigation("RefreshTokens");

                    b.Navigation("UserDashboardSettings");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Campaign", b =>
                {
                    b.Navigation("AdGroups");

                    b.Navigation("Performances");
                });

            modelBuilder.Entity("Google_Ads___PPC_Dashboard.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
