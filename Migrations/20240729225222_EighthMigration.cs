using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSolution.Migrations
{
    /// <inheritdoc />
    public partial class EighthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65836013-3d00-4eaa-80aa-1d6e86970df2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2119fdd-2c7f-4216-93dc-7eccb248362b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca271f67-f3f0-49fb-8370-6bd57a6ca95b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f20d941-25a0-4fec-8297-33da3dbc489d", null, "teammanager", "TeamManager" },
                    { "994d53c9-2a7b-4ac9-94a0-b64e62f51907", null, "admin", "Admin" },
                    { "e93264d4-a75e-4380-aa37-de0fb4e93e85", null, "basicuser", "BasicUser" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f20d941-25a0-4fec-8297-33da3dbc489d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994d53c9-2a7b-4ac9-94a0-b64e62f51907");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e93264d4-a75e-4380-aa37-de0fb4e93e85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65836013-3d00-4eaa-80aa-1d6e86970df2", null, "basicuser", "BasicUser" },
                    { "c2119fdd-2c7f-4216-93dc-7eccb248362b", null, "teammanager", "TeamManager" },
                    { "ca271f67-f3f0-49fb-8370-6bd57a6ca95b", null, "admin", "Admin" }
                });
        }
    }
}
