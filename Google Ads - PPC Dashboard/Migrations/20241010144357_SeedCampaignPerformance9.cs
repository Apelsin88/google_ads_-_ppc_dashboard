using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Google_Ads___PPC_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class SeedCampaignPerformance9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 9, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 9, 30, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 5, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.InsertData(
                table: "CampaignPerformances",
                columns: new[] { "Id", "CampaignId", "Clicks", "ConversionValue", "Conversions", "Cost", "Date", "Impressions" },
                values: new object[,]
                {
                    { 1, 1, 50, 1000m, 10, 500m, new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1000 },
                    { 2, 1, 52, 1050m, 11, 525m, new DateTime(2024, 9, 11, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1050 },
                    { 3, 1, 54, 1100m, 12, 550m, new DateTime(2024, 9, 12, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1100 },
                    { 4, 1, 56, 1150m, 13, 575m, new DateTime(2024, 9, 13, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1150 },
                    { 5, 1, 58, 1200m, 14, 600m, new DateTime(2024, 9, 14, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1200 },
                    { 6, 1, 60, 1250m, 15, 625m, new DateTime(2024, 9, 15, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1250 },
                    { 7, 1, 62, 1300m, 16, 650m, new DateTime(2024, 9, 16, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1300 },
                    { 8, 1, 64, 1350m, 17, 675m, new DateTime(2024, 9, 17, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1350 },
                    { 9, 1, 66, 1400m, 18, 700m, new DateTime(2024, 9, 18, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1400 },
                    { 10, 1, 68, 1450m, 19, 725m, new DateTime(2024, 9, 19, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1450 },
                    { 11, 1, 70, 1500m, 20, 750m, new DateTime(2024, 9, 20, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1500 },
                    { 12, 1, 72, 1550m, 21, 775m, new DateTime(2024, 9, 21, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1550 },
                    { 13, 1, 74, 1600m, 22, 800m, new DateTime(2024, 9, 22, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1600 },
                    { 14, 1, 76, 1650m, 23, 825m, new DateTime(2024, 9, 23, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1650 },
                    { 15, 1, 78, 1700m, 24, 850m, new DateTime(2024, 9, 24, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1700 },
                    { 16, 1, 80, 1750m, 25, 875m, new DateTime(2024, 9, 25, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1750 },
                    { 17, 1, 82, 1800m, 26, 900m, new DateTime(2024, 9, 26, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1800 },
                    { 18, 1, 84, 1850m, 27, 925m, new DateTime(2024, 9, 27, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1850 },
                    { 19, 1, 86, 1900m, 28, 950m, new DateTime(2024, 9, 28, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1900 },
                    { 20, 1, 88, 1950m, 29, 975m, new DateTime(2024, 9, 29, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1950 },
                    { 21, 1, 90, 2000m, 30, 1000m, new DateTime(2024, 9, 30, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2000 },
                    { 22, 1, 92, 2050m, 31, 1025m, new DateTime(2024, 10, 1, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2050 },
                    { 23, 1, 94, 2100m, 32, 1050m, new DateTime(2024, 10, 2, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2100 },
                    { 24, 1, 96, 2150m, 33, 1075m, new DateTime(2024, 10, 3, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2150 },
                    { 25, 1, 98, 2200m, 34, 1100m, new DateTime(2024, 10, 4, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2200 },
                    { 26, 1, 100, 2250m, 35, 1125m, new DateTime(2024, 10, 5, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2250 },
                    { 27, 1, 102, 2300m, 36, 1150m, new DateTime(2024, 10, 6, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2300 },
                    { 28, 1, 104, 2350m, 37, 1175m, new DateTime(2024, 10, 7, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2350 },
                    { 29, 1, 106, 2400m, 38, 1200m, new DateTime(2024, 10, 8, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2400 },
                    { 30, 1, 108, 2450m, 39, 1225m, new DateTime(2024, 10, 9, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2450 },
                    { 31, 2, 45, 900m, 9, 450m, new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 900 },
                    { 32, 2, 47, 950m, 10, 475m, new DateTime(2024, 9, 11, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 950 },
                    { 33, 2, 49, 1000m, 11, 500m, new DateTime(2024, 9, 12, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1000 },
                    { 34, 2, 51, 1050m, 12, 525m, new DateTime(2024, 9, 13, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1050 },
                    { 35, 2, 53, 1100m, 13, 550m, new DateTime(2024, 9, 14, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1100 },
                    { 36, 2, 55, 1150m, 14, 575m, new DateTime(2024, 9, 15, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1150 },
                    { 37, 2, 57, 1200m, 15, 600m, new DateTime(2024, 9, 16, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1200 },
                    { 38, 2, 59, 1250m, 16, 625m, new DateTime(2024, 9, 17, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1250 },
                    { 39, 2, 61, 1300m, 17, 650m, new DateTime(2024, 9, 18, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1300 },
                    { 40, 2, 63, 1350m, 18, 675m, new DateTime(2024, 9, 19, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1350 },
                    { 41, 2, 65, 1400m, 19, 700m, new DateTime(2024, 9, 20, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1400 },
                    { 42, 2, 67, 1450m, 20, 725m, new DateTime(2024, 9, 21, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1450 },
                    { 43, 2, 69, 1500m, 21, 750m, new DateTime(2024, 9, 22, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1500 },
                    { 44, 2, 71, 1550m, 22, 775m, new DateTime(2024, 9, 23, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1550 },
                    { 45, 2, 73, 1600m, 23, 800m, new DateTime(2024, 9, 24, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1600 },
                    { 46, 2, 75, 1650m, 24, 825m, new DateTime(2024, 9, 25, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1650 },
                    { 47, 2, 77, 1700m, 25, 850m, new DateTime(2024, 9, 26, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1700 },
                    { 48, 2, 79, 1750m, 26, 875m, new DateTime(2024, 9, 27, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1750 },
                    { 49, 2, 81, 1800m, 27, 900m, new DateTime(2024, 9, 28, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1800 },
                    { 50, 2, 83, 1850m, 28, 925m, new DateTime(2024, 9, 29, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1850 },
                    { 51, 2, 85, 1900m, 29, 950m, new DateTime(2024, 9, 30, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1900 },
                    { 52, 2, 87, 1950m, 30, 975m, new DateTime(2024, 10, 1, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1950 },
                    { 53, 2, 89, 2000m, 31, 1000m, new DateTime(2024, 10, 2, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2000 },
                    { 54, 2, 91, 2050m, 32, 1025m, new DateTime(2024, 10, 3, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2050 },
                    { 55, 2, 93, 2100m, 33, 1050m, new DateTime(2024, 10, 4, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2100 },
                    { 56, 2, 95, 2150m, 34, 1075m, new DateTime(2024, 10, 5, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2150 },
                    { 57, 2, 97, 2200m, 35, 1100m, new DateTime(2024, 10, 6, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2200 },
                    { 58, 2, 99, 2250m, 36, 1125m, new DateTime(2024, 10, 7, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2250 },
                    { 59, 2, 101, 2300m, 37, 1150m, new DateTime(2024, 10, 8, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2300 },
                    { 60, 2, 103, 2350m, 38, 1175m, new DateTime(2024, 10, 9, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2350 },
                    { 61, 3, 100, 2000m, 20, 1000m, new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2000 },
                    { 62, 3, 102, 2050m, 21, 1025m, new DateTime(2024, 9, 11, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2050 },
                    { 63, 3, 104, 2100m, 22, 1050m, new DateTime(2024, 9, 12, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2100 },
                    { 64, 3, 106, 2150m, 23, 1075m, new DateTime(2024, 9, 13, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2150 },
                    { 65, 3, 108, 2200m, 24, 1100m, new DateTime(2024, 9, 14, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2200 },
                    { 66, 3, 110, 2250m, 25, 1125m, new DateTime(2024, 9, 15, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2250 },
                    { 67, 3, 112, 2300m, 26, 1150m, new DateTime(2024, 9, 16, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2300 },
                    { 68, 3, 114, 2350m, 27, 1175m, new DateTime(2024, 9, 17, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2350 },
                    { 69, 3, 116, 2400m, 28, 1200m, new DateTime(2024, 9, 18, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2400 },
                    { 70, 3, 118, 2450m, 29, 1225m, new DateTime(2024, 9, 19, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2450 },
                    { 71, 3, 120, 2500m, 30, 1250m, new DateTime(2024, 9, 20, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2500 },
                    { 72, 3, 122, 2550m, 31, 1275m, new DateTime(2024, 9, 21, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2550 },
                    { 73, 3, 124, 2600m, 32, 1300m, new DateTime(2024, 9, 22, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2600 },
                    { 74, 3, 126, 2650m, 33, 1325m, new DateTime(2024, 9, 23, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2650 },
                    { 75, 3, 128, 2700m, 34, 1350m, new DateTime(2024, 9, 24, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2700 },
                    { 76, 3, 130, 2750m, 35, 1375m, new DateTime(2024, 9, 25, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2750 },
                    { 77, 3, 132, 2800m, 36, 1400m, new DateTime(2024, 9, 26, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2800 },
                    { 78, 3, 134, 2850m, 37, 1425m, new DateTime(2024, 9, 27, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2850 },
                    { 79, 3, 136, 2900m, 38, 1450m, new DateTime(2024, 9, 28, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2900 },
                    { 80, 3, 138, 2950m, 39, 1475m, new DateTime(2024, 9, 29, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 2950 },
                    { 81, 3, 140, 3000m, 40, 1500m, new DateTime(2024, 9, 30, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3000 },
                    { 82, 3, 142, 3050m, 41, 1525m, new DateTime(2024, 10, 1, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3050 },
                    { 83, 3, 144, 3100m, 42, 1550m, new DateTime(2024, 10, 2, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3100 },
                    { 84, 3, 146, 3150m, 43, 1575m, new DateTime(2024, 10, 3, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3150 },
                    { 85, 3, 148, 3200m, 44, 1600m, new DateTime(2024, 10, 4, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3200 },
                    { 86, 3, 150, 3250m, 45, 1625m, new DateTime(2024, 10, 5, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3250 },
                    { 87, 3, 152, 3300m, 46, 1650m, new DateTime(2024, 10, 6, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3300 },
                    { 88, 3, 154, 3350m, 47, 1675m, new DateTime(2024, 10, 7, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3350 },
                    { 89, 3, 156, 3400m, 48, 1700m, new DateTime(2024, 10, 8, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3400 },
                    { 90, 3, 158, 3450m, 49, 1725m, new DateTime(2024, 10, 9, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3450 },
                    { 91, 4, 25, 500m, 5, 250m, new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 500 },
                    { 92, 4, 28, 550m, 6, 280m, new DateTime(2024, 9, 11, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 550 },
                    { 93, 4, 30, 600m, 7, 300m, new DateTime(2024, 9, 12, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 600 },
                    { 94, 4, 32, 650m, 8, 320m, new DateTime(2024, 9, 13, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 650 },
                    { 95, 4, 35, 700m, 9, 350m, new DateTime(2024, 9, 14, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 700 },
                    { 96, 4, 37, 750m, 10, 375m, new DateTime(2024, 9, 15, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 750 },
                    { 97, 4, 40, 800m, 11, 400m, new DateTime(2024, 9, 16, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 800 },
                    { 98, 4, 42, 850m, 12, 425m, new DateTime(2024, 9, 17, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 850 },
                    { 99, 4, 45, 900m, 13, 450m, new DateTime(2024, 9, 18, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 900 },
                    { 100, 4, 48, 950m, 14, 475m, new DateTime(2024, 9, 19, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 950 },
                    { 101, 4, 50, 1000m, 15, 500m, new DateTime(2024, 9, 20, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1000 },
                    { 102, 4, 52, 1050m, 16, 525m, new DateTime(2024, 9, 21, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1050 },
                    { 103, 4, 54, 1100m, 17, 550m, new DateTime(2024, 9, 22, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1100 },
                    { 104, 4, 56, 1150m, 18, 575m, new DateTime(2024, 9, 23, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1150 },
                    { 105, 4, 58, 1200m, 19, 600m, new DateTime(2024, 9, 24, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1200 },
                    { 106, 4, 60, 1250m, 20, 625m, new DateTime(2024, 9, 25, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1250 },
                    { 107, 4, 62, 1300m, 21, 650m, new DateTime(2024, 9, 26, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1300 },
                    { 108, 4, 64, 1350m, 22, 675m, new DateTime(2024, 9, 27, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1350 },
                    { 109, 4, 66, 1400m, 23, 700m, new DateTime(2024, 9, 28, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1400 },
                    { 110, 4, 68, 1450m, 24, 725m, new DateTime(2024, 9, 29, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1450 },
                    { 111, 4, 70, 1500m, 25, 750m, new DateTime(2024, 9, 30, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1500 },
                    { 112, 4, 72, 1550m, 26, 775m, new DateTime(2024, 10, 1, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1550 },
                    { 113, 4, 74, 1600m, 27, 800m, new DateTime(2024, 10, 2, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1600 },
                    { 114, 4, 76, 1650m, 28, 825m, new DateTime(2024, 10, 3, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1650 },
                    { 115, 4, 78, 1700m, 29, 850m, new DateTime(2024, 10, 4, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1700 },
                    { 116, 4, 80, 1750m, 30, 875m, new DateTime(2024, 10, 5, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1750 },
                    { 117, 4, 82, 1800m, 31, 900m, new DateTime(2024, 10, 6, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1800 },
                    { 118, 4, 84, 1850m, 32, 925m, new DateTime(2024, 10, 7, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1850 },
                    { 119, 4, 86, 1900m, 33, 950m, new DateTime(2024, 10, 8, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1900 },
                    { 120, 4, 88, 1950m, 34, 975m, new DateTime(2024, 10, 9, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 1950 },
                    { 121, 5, 150, 3000m, 30, 1500m, new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3000 },
                    { 122, 5, 155, 3100m, 31, 1550m, new DateTime(2024, 9, 11, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3100 },
                    { 123, 5, 160, 3200m, 32, 1600m, new DateTime(2024, 9, 12, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3200 },
                    { 124, 5, 165, 3300m, 33, 1650m, new DateTime(2024, 9, 13, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3300 },
                    { 125, 5, 170, 3400m, 34, 1700m, new DateTime(2024, 9, 14, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3400 },
                    { 126, 5, 175, 3500m, 35, 1750m, new DateTime(2024, 9, 15, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3500 },
                    { 127, 5, 180, 3600m, 36, 1800m, new DateTime(2024, 9, 16, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3600 },
                    { 128, 5, 185, 3700m, 37, 1850m, new DateTime(2024, 9, 17, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3700 },
                    { 129, 5, 190, 3800m, 38, 1900m, new DateTime(2024, 9, 18, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3800 },
                    { 130, 5, 195, 3900m, 39, 1950m, new DateTime(2024, 9, 19, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 3900 },
                    { 131, 5, 200, 4000m, 40, 2000m, new DateTime(2024, 9, 20, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4000 },
                    { 132, 5, 205, 4100m, 41, 2050m, new DateTime(2024, 9, 21, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4100 },
                    { 133, 5, 210, 4200m, 42, 2100m, new DateTime(2024, 9, 22, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4200 },
                    { 134, 5, 215, 4300m, 43, 2150m, new DateTime(2024, 9, 23, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4300 },
                    { 135, 5, 220, 4400m, 44, 2200m, new DateTime(2024, 9, 24, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4400 },
                    { 136, 5, 225, 4500m, 45, 2250m, new DateTime(2024, 9, 25, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4500 },
                    { 137, 5, 230, 4600m, 46, 2300m, new DateTime(2024, 9, 26, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4600 },
                    { 138, 5, 235, 4700m, 47, 2350m, new DateTime(2024, 9, 27, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4700 },
                    { 139, 5, 240, 4800m, 48, 2400m, new DateTime(2024, 9, 28, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4800 },
                    { 140, 5, 245, 4900m, 49, 2450m, new DateTime(2024, 9, 29, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 4900 },
                    { 141, 5, 250, 5000m, 50, 2500m, new DateTime(2024, 9, 30, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5000 },
                    { 142, 5, 255, 5100m, 51, 2550m, new DateTime(2024, 10, 1, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5100 },
                    { 143, 5, 260, 5200m, 52, 2600m, new DateTime(2024, 10, 2, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5200 },
                    { 144, 5, 265, 5300m, 53, 2650m, new DateTime(2024, 10, 3, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5300 },
                    { 145, 5, 270, 5400m, 54, 2700m, new DateTime(2024, 10, 4, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5400 },
                    { 146, 5, 275, 5500m, 55, 2750m, new DateTime(2024, 10, 5, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5500 },
                    { 147, 5, 280, 5600m, 56, 2800m, new DateTime(2024, 10, 6, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5600 },
                    { 148, 5, 285, 5700m, 57, 2850m, new DateTime(2024, 10, 7, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5700 },
                    { 149, 5, 290, 5800m, 58, 2900m, new DateTime(2024, 10, 8, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5800 },
                    { 150, 5, 295, 5900m, 59, 2950m, new DateTime(2024, 10, 9, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), 5900 }
                });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 9, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 8, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 10, 10, 14, 43, 56, 592, DateTimeKind.Utc).AddTicks(69) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "CampaignPerformances",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 12, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 3, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "LastLogin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 8, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 8, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 7, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618), new DateTime(2024, 9, 13, 11, 8, 13, 107, DateTimeKind.Utc).AddTicks(7618) });
        }
    }
}
