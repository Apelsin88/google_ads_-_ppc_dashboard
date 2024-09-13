using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Google_Ads___PPC_Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class NusåMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserDashboardSettings",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "RefreshTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_UserDashboardSettings_UserId",
                table: "UserDashboardSettings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_AdGroupId",
                table: "Keywords",
                column: "AdGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_AdGroups_AdGroupId",
                table: "Keywords",
                column: "AdGroupId",
                principalTable: "AdGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshTokens_ApplicationUsers_UserId",
                table: "RefreshTokens",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDashboardSettings_ApplicationUsers_UserId",
                table: "UserDashboardSettings",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_AdGroups_AdGroupId",
                table: "Keywords");

            migrationBuilder.DropForeignKey(
                name: "FK_RefreshTokens_ApplicationUsers_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDashboardSettings_ApplicationUsers_UserId",
                table: "UserDashboardSettings");

            migrationBuilder.DropIndex(
                name: "IX_UserDashboardSettings_UserId",
                table: "UserDashboardSettings");

            migrationBuilder.DropIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens");

            migrationBuilder.DropIndex(
                name: "IX_Keywords_AdGroupId",
                table: "Keywords");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserDashboardSettings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "RefreshTokens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
