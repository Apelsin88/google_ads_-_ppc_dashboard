using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Google_Ads___PPC_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoogleCampaignId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Budget = table.Column<decimal>(type: "TEXT", nullable: false),
                    BudgetType = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConversionGoals",
                columns: table => new
                {
                    ConversionGoalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversionGoals", x => x.ConversionGoalId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NormalizedName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Configuration = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomReports_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDashboardSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    WidgetType = table.Column<string>(type: "TEXT", nullable: false),
                    WidgetPosition = table.Column<int>(type: "INTEGER", nullable: false),
                    WidgetSettings = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDashboardSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDashboardSettings_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoogleAdGroup = table.Column<string>(type: "TEXT", nullable: true),
                    CampaignId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdGroups_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignPerformances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CampaignId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Impressions = table.Column<int>(type: "INTEGER", nullable: false),
                    Clicks = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    Conversions = table.Column<int>(type: "INTEGER", nullable: false),
                    ConversionValue = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignPerformances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignPerformances_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoogleAdId = table.Column<string>(type: "TEXT", nullable: false),
                    AdGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    AdType = table.Column<string>(type: "TEXT", nullable: false),
                    HeadlinePart1 = table.Column<string>(type: "TEXT", nullable: false),
                    HeadlinePart2 = table.Column<string>(type: "TEXT", nullable: false),
                    Description1 = table.Column<string>(type: "TEXT", nullable: false),
                    FinalUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ads_AdGroups_AdGroupId",
                        column: x => x.AdGroupId,
                        principalTable: "AdGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GoogleKeywordId = table.Column<string>(type: "TEXT", nullable: false),
                    AdGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    KeywordText = table.Column<string>(type: "TEXT", nullable: false),
                    MatchType = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Bid = table.Column<decimal>(type: "TEXT", nullable: true),
                    QualityScore = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keywords_AdGroups_AdGroupId",
                        column: x => x.AdGroupId,
                        principalTable: "AdGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsActive", "LastLogin", "LastName", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { "1", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "john.doe@example.com", "John", true, new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Doe", "hashedpassword1", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "john.doe" },
                    { "2", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "jane.smith@example.com", "Jane", true, new DateTime(2024, 9, 12, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Smith", "hashedpassword2", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "jane.smith" },
                    { "3", new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "mike.jones@example.com", "Mike", false, new DateTime(2024, 9, 3, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Jones", "hashedpassword3", new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "mike.jones" },
                    { "4", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "emma.brown@example.com", "Emma", true, new DateTime(2024, 9, 8, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Brown", "hashedpassword4", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "emma.brown" }
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "Id", "Budget", "BudgetType", "CreatedAt", "EndDate", "GoogleCampaignId", "Name", "StartDate", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 5000m, "Daily", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), null, "GC001", "Summer Sale", new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Active", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) },
                    { 2, 3000m, "Monthly", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), null, "GC002", "Winter Sale", new DateTime(2024, 7, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Paused", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) }
                });

            migrationBuilder.InsertData(
                table: "AdGroups",
                columns: new[] { "Id", "CampaignId", "CreatedAt", "GoogleAdGroup", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), null, "Discount Ads", "Enabled", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) },
                    { 2, 2, new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), null, "Holiday Ads", "Paused", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Id", "AdGroupId", "AdType", "CreatedAt", "Description1", "FinalUrl", "GoogleAdId", "HeadlinePart1", "HeadlinePart2", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Text", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Save up to 50%", "https://example.com", "AD001", "Huge Discounts", "Shop Now", "Active", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) },
                    { 2, 2, "Display", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), "Don't Miss Out", "https://example.com", "AD002", "Winter Special", "Limited Time Offer", "Paused", new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdGroups_CampaignId",
                table: "AdGroups",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_AdGroupId",
                table: "Ads",
                column: "AdGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignPerformances_CampaignId",
                table: "CampaignPerformances",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomReports_UserId",
                table: "CustomReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_AdGroupId",
                table: "Keywords",
                column: "AdGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDashboardSettings_UserId",
                table: "UserDashboardSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "CampaignPerformances");

            migrationBuilder.DropTable(
                name: "ConversionGoals");

            migrationBuilder.DropTable(
                name: "CustomReports");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserDashboardSettings");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "AdGroups");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Campaigns");
        }
    }
}
