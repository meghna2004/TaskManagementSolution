using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagementSolution.Migrations
{
    /// <inheritdoc />
    public partial class SeventhMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSupport_AspNetUsers_AccountId",
                table: "CustomerSupport");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_AspNetUsers_OwnerId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_TaskList_TaskListID",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskList_AspNetUsers_OwnerId",
                table: "TaskList");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskManager_AspNetUsers_AccountId",
                table: "TaskManager");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskUser_AspNetUsers_AccountId",
                table: "TaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_AspNetUsers_AccountId",
                table: "TeamMember");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_AspNetUsers_UserId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_AccountId",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TaskUser_AccountId",
                table: "TaskUser");

            migrationBuilder.DropIndex(
                name: "IX_TaskManager_AccountId",
                table: "TaskManager");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSupport_AccountId",
                table: "CustomerSupport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

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
                name: "UserId",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "TaskUser");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "TaskManager");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "CustomerSupport");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "TaskList",
                newName: "OwnerID");

            migrationBuilder.RenameIndex(
                name: "IX_TaskList_OwnerId",
                table: "TaskList",
                newName: "IX_TaskList_OwnerID");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Tasks",
                newName: "OwnerID");

            migrationBuilder.RenameIndex(
                name: "IX_Task_TaskListID",
                table: "Tasks",
                newName: "IX_Tasks_TaskListID");

            migrationBuilder.RenameIndex(
                name: "IX_Task_OwnerId",
                table: "Tasks",
                newName: "IX_Tasks_OwnerID");

            migrationBuilder.AddColumn<string>(
                name: "SystemUserID",
                table: "UserAddress",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SystemUserID",
                table: "TeamMember",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SystemUserID",
                table: "TaskUser",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SystemUserID",
                table: "TaskManager",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerID",
                table: "TaskList",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemUserID",
                table: "CustomerSupport",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerID",
                table: "Tasks",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "TaskID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fbd9b4a-faf6-4511-be56-4010826ff4e1", null, "teammanager", "TeamManager" },
                    { "86b63ea3-6603-478c-8e93-ddad82694454", null, "admin", "Admin" },
                    { "d614b891-2608-4f16-b72e-bd138dc6e5a7", null, "basicuser", "BasicUser" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_SystemUserID",
                table: "UserAddress",
                column: "SystemUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_SystemUserID",
                table: "TeamMember",
                column: "SystemUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_SystemUserID",
                table: "TaskUser",
                column: "SystemUserID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManager_SystemUserID",
                table: "TaskManager",
                column: "SystemUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSupport_SystemUserID",
                table: "CustomerSupport",
                column: "SystemUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSupport_AspNetUsers_SystemUserID",
                table: "CustomerSupport",
                column: "SystemUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskList_AspNetUsers_OwnerID",
                table: "TaskList",
                column: "OwnerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskManager_AspNetUsers_SystemUserID",
                table: "TaskManager",
                column: "SystemUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_OwnerID",
                table: "Tasks",
                column: "OwnerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskList_TaskListID",
                table: "Tasks",
                column: "TaskListID",
                principalTable: "TaskList",
                principalColumn: "TaskListID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskUser_AspNetUsers_SystemUserID",
                table: "TaskUser",
                column: "SystemUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_AspNetUsers_SystemUserID",
                table: "TeamMember",
                column: "SystemUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_AspNetUsers_SystemUserID",
                table: "UserAddress",
                column: "SystemUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSupport_AspNetUsers_SystemUserID",
                table: "CustomerSupport");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskList_AspNetUsers_OwnerID",
                table: "TaskList");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskManager_AspNetUsers_SystemUserID",
                table: "TaskManager");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_OwnerID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskList_TaskListID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskUser_AspNetUsers_SystemUserID",
                table: "TaskUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_AspNetUsers_SystemUserID",
                table: "TeamMember");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddress_AspNetUsers_SystemUserID",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_UserAddress_SystemUserID",
                table: "UserAddress");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_SystemUserID",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TaskUser_SystemUserID",
                table: "TaskUser");

            migrationBuilder.DropIndex(
                name: "IX_TaskManager_SystemUserID",
                table: "TaskManager");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSupport_SystemUserID",
                table: "CustomerSupport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

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

            migrationBuilder.DropColumn(
                name: "SystemUserID",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "SystemUserID",
                table: "TeamMember");

            migrationBuilder.DropColumn(
                name: "SystemUserID",
                table: "TaskUser");

            migrationBuilder.DropColumn(
                name: "SystemUserID",
                table: "TaskManager");

            migrationBuilder.DropColumn(
                name: "SystemUserID",
                table: "CustomerSupport");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "TaskList",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskList_OwnerID",
                table: "TaskList",
                newName: "IX_TaskList_OwnerId");

            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "Task",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_TaskListID",
                table: "Task",
                newName: "IX_Task_TaskListID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_OwnerID",
                table: "Task",
                newName: "IX_Task_OwnerId");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserAddress",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "TeamMember",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "TaskUser",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "TaskManager",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "TaskList",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "CustomerSupport",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Task",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "TaskID");

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
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_AccountId",
                table: "TeamMember",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskUser_AccountId",
                table: "TaskUser",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManager_AccountId",
                table: "TaskManager",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSupport_AccountId",
                table: "CustomerSupport",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSupport_AspNetUsers_AccountId",
                table: "CustomerSupport",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_AspNetUsers_OwnerId",
                table: "Task",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_TaskList_TaskListID",
                table: "Task",
                column: "TaskListID",
                principalTable: "TaskList",
                principalColumn: "TaskListID");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskList_AspNetUsers_OwnerId",
                table: "TaskList",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskManager_AspNetUsers_AccountId",
                table: "TaskManager",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskUser_AspNetUsers_AccountId",
                table: "TaskUser",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_AspNetUsers_AccountId",
                table: "TeamMember",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddress_AspNetUsers_UserId",
                table: "UserAddress",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
