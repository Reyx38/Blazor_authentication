using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_authentication.Migrations
{
    /// <inheritdoc />
    public partial class CreandoUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user2-id", 0, "64ccc04a-feac-4431-bc17-4101c3340053", "Darvyn@Luis.com", true, false, null, "DARVYN@LUIS.COM", "DARVYN@LUIS.COM", "AQAAAAIAAYagAAAAEPQ+dLazNnNCOLOHYf3ckLPkteVoYJlu6GjwgmreUWephuLIUBXkbPVUx1p3VlEc3Q==", null, false, "8500a627-dc07-40d4-836a-df6968752661", false, "Darvyn@Luis.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a82922b-1c74-4962-a328-5c3ab1e2a8a7", "user2-id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a82922b-1c74-4962-a328-5c3ab1e2a8a7", "user2-id" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2-id");
        }
    }
}
