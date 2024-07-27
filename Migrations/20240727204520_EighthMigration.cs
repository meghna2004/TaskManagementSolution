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
                keyValue: "2fbd9b4a-faf6-4511-be56-4010826ff4e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86b63ea3-6603-478c-8e93-ddad82694454");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d614b891-2608-4f16-b72e-bd138dc6e5a7");

            migrationBuilder.AlterColumn<decimal>(
                name: "Estimate",
                table: "Tasks",
                type: "decimal(16,2)",
                precision: 16,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Estimate",
                table: "TaskList",
                type: "decimal(16,2)",
                precision: 16,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2,
                oldScale: 2);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Estimate",
                table: "Tasks",
                type: "decimal(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,2)",
                oldPrecision: 16,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Estimate",
                table: "TaskList",
                type: "decimal(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,2)",
                oldPrecision: 16,
                oldScale: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fbd9b4a-faf6-4511-be56-4010826ff4e1", null, "teammanager", "TeamManager" },
                    { "86b63ea3-6603-478c-8e93-ddad82694454", null, "admin", "Admin" },
                    { "d614b891-2608-4f16-b72e-bd138dc6e5a7", null, "basicuser", "BasicUser" }
                });
        }
    }
}
