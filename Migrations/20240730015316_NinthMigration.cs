using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSolution.Migrations
{
    /// <inheritdoc />
    public partial class NinthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskList_Team_TeamID",
                table: "TaskList");

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

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "TaskList",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "327978a5-c712-4e4c-b591-33a560c6bf9a", null, "teammanager", "TeamManager" },
                    { "a5e0c3cf-3471-4866-8af7-f16c3fada852", null, "admin", "Admin" },
                    { "d5587c87-fdd0-4a43-ac1d-710dd2ec2425", null, "basicuser", "BasicUser" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskList_Team_TeamID",
                table: "TaskList",
                column: "TeamID",
                principalTable: "Team",
                principalColumn: "TeamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskList_Team_TeamID",
                table: "TaskList");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "327978a5-c712-4e4c-b591-33a560c6bf9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e0c3cf-3471-4866-8af7-f16c3fada852");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5587c87-fdd0-4a43-ac1d-710dd2ec2425");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "TaskList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f20d941-25a0-4fec-8297-33da3dbc489d", null, "teammanager", "TeamManager" },
                    { "994d53c9-2a7b-4ac9-94a0-b64e62f51907", null, "admin", "Admin" },
                    { "e93264d4-a75e-4380-aa37-de0fb4e93e85", null, "basicuser", "BasicUser" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskList_Team_TeamID",
                table: "TaskList",
                column: "TeamID",
                principalTable: "Team",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
