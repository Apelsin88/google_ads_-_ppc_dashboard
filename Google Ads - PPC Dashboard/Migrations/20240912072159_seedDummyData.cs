using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Google_Ads___PPC_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class seedDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "Id", "Budget", "BudgetType", "CreatedAt", "EndDate", "GoogleCampaignId", "Name", "StartDate", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 5000m, "Daily", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1344), null, "GC001", "Summer Sale", new DateTime(2024, 8, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1289), "Active", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1346) },
                    { 2, 3000m, "Monthly", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1351), null, "GC002", "Winter Sale", new DateTime(2024, 7, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1349), "Paused", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1352) }
                });

            migrationBuilder.InsertData(
                table: "AdGroups",
                columns: new[] { "Id", "CampaignId", "CreatedAt", "GoogleAdGroup", "Name", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1469), null, "Discount Ads", "Enabled", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1471) },
                    { 2, 2, new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1473), null, "Holiday Ads", "Paused", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1475) }
                });

            migrationBuilder.InsertData(
                table: "Ads",
                columns: new[] { "Id", "AdGroupId", "AdType", "CreatedAt", "Description1", "FinalUrl", "GoogleAdId", "HeadlinePart1", "HeadlinePart2", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Text", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1503), "Save up to 50%", "https://example.com", "AD001", "Huge Discounts", "Shop Now", "Active", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1505) },
                    { 2, 2, "Display", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1508), "Don't Miss Out", "https://example.com", "AD002", "Winter Special", "Limited Time Offer", "Paused", new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1509) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
