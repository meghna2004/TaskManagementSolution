using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSolution.Migrations
{
    /// <inheritdoc />
    public partial class SixthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14533c8d-5a6b-4843-8f86-5ffcce8daa53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a86a244-f9f8-4e36-b1d9-78da357dad4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6909c95-fe14-48cc-a3dc-a88d4df311c1");

            

            migrationBuilder.AddColumn<int>(
                name: "accounttype",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

           

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SecondLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThirdLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    County = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSupport",
                columns: table => new
                {
                    CustomerSupportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSupport", x => x.CustomerSupportID);
                    table.ForeignKey(
                        name: "FK_CustomerSupport_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaskManager",
                columns: table => new
                {
                    TaskManagerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskManager", x => x.TaskManagerID);
                    table.ForeignKey(
                        name: "FK_TaskManager_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaskUser",
                columns: table => new
                {
                    TaskUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUser", x => x.TaskUserID);
                    table.ForeignKey(
                        name: "FK_TaskUser_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    UserAddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AddressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.UserAddressID);
                    table.ForeignKey(
                        name: "FK_UserAddress_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddress_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaskList",
                columns: table => new
                {
                    TaskListID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Estimate = table.Column<decimal>(type: "decimal(2,2)", precision: 2, scale: 2, nullable: false),
                    StatusReason = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskList", x => x.TaskListID);
                    table.ForeignKey(
                        name: "FK_TaskList_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaskList_Team_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskListID = table.Column<int>(type: "int", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Estimate = table.Column<decimal>(type: "decimal(2,2)", precision: 2, scale: 2, nullable: false),
                    StatusReason = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Task_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Task_TaskList_TaskListID",
                        column: x => x.TaskListID,
                        principalTable: "TaskList",
                        principalColumn: "TaskListID");
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    TeamMemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    TaskListID = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursSpent = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.TeamMemberID);
                    table.ForeignKey(
                        name: "FK_TeamMember_AspNetUsers_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeamMember_TaskList_TaskListID",
                        column: x => x.TaskListID,
                        principalTable: "TaskList",
                        principalColumn: "TaskListID");
                    table.ForeignKey(
                        name: "FK_TeamMember_Team_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f640723-13b1-4796-a5dd-c1e0afc2e5ea", null, "admin", "Admin" },
                    { "48fc74dd-b60b-4f63-be2a-6a6e39377fa0", null, "basicuser", "BasicUser" },
                    { "8985be58-13d6-4478-b47f-14d5c8ef1156", null, "teammanager", "TeamManager" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSupport_AccountId",
                table: "CustomerSupport",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_OwnerId",
                table: "Task",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_TaskListID",
                table: "Task",
                column: "TaskListID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskList_OwnerId",
                table: "TaskList",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskList_TeamID",
                table: "TaskList",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManager_AccountId",
                table: "TaskManager",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_AccountId",
                table: "TaskUser",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_AccountId",
                table: "TeamMember",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_TaskListID",
                table: "TeamMember",
                column: "TaskListID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_TeamID",
                table: "TeamMember",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_AddressID",
                table: "UserAddress",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerSupport");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "TaskManager");

            migrationBuilder.DropTable(
                name: "TaskUser");

            migrationBuilder.DropTable(
                name: "TeamMember");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "TaskList");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f640723-13b1-4796-a5dd-c1e0afc2e5ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48fc74dd-b60b-4f63-be2a-6a6e39377fa0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8985be58-13d6-4478-b47f-14d5c8ef1156");

            migrationBuilder.DropColumn(
                name: "accounttype",
                table: "AspNetUsers");

            

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14533c8d-5a6b-4843-8f86-5ffcce8daa53", null, "teammanager", "TeamManager" },
                    { "5a86a244-f9f8-4e36-b1d9-78da357dad4f", null, "admin", "Admin" },
                    { "c6909c95-fe14-48cc-a3dc-a88d4df311c1", null, "basicuser", "BasicUser" }
                });
        }
    }
}
