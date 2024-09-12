using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Google_Ads___PPC_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUsersSeedDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2489), new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2530), new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsActive", "LastLogin", "LastName", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { "1", new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2560), "john.doe@example.com", "John", true, new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2562), "Doe", "hashedpassword1", new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2561), "john.doe" },
                    { "2", new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2565), "jane.smith@example.com", "Jane", true, new DateTime(2024, 9, 11, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2567), "Smith", "hashedpassword2", new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2566), "jane.smith" },
                    { "3", new DateTime(2024, 8, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2572), "mike.jones@example.com", "Mike", false, new DateTime(2024, 9, 2, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2575), "Jones", "hashedpassword3", new DateTime(2024, 8, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2574), "mike.jones" },
                    { "4", new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2577), "emma.brown@example.com", "Emma", true, new DateTime(2024, 9, 7, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2580), "Brown", "hashedpassword4", new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2579), "emma.brown" }
                });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 8, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2304), new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2369), new DateTime(2024, 7, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2368), new DateTime(2024, 9, 12, 10, 3, 33, 426, DateTimeKind.Local).AddTicks(2370) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1469), new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "AdGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1344), new DateTime(2024, 8, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1289), new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 7, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 9, 12, 9, 21, 58, 622, DateTimeKind.Local).AddTicks(1352) });
        }
    }
}
