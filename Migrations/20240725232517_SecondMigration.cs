using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSolution.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1262ab11-488e-4be6-96ac-1af9c5bb5224", null, "admin", "Admin" },
                    { "b40691f1-1ee7-4935-9a2d-92b3c1cd2426", null, "basicuser", "BasicUser" },
                    { "cd9b6250-1bd6-4920-88cb-683ee7ca30a7", null, "teammanager", "TeamManager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1262ab11-488e-4be6-96ac-1af9c5bb5224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b40691f1-1ee7-4935-9a2d-92b3c1cd2426");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd9b6250-1bd6-4920-88cb-683ee7ca30a7");
        }
    }
}
