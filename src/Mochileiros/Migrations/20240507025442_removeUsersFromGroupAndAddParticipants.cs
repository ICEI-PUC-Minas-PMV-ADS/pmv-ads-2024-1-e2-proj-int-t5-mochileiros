using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mochileiros.Migrations
{
    public partial class RemoveUsersAndChangeToParticipants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        

            migrationBuilder.DropTable(
                name: "GroupUsers");

            migrationBuilder.DropColumn(
                name: "Users",
                table: "Group");

            migrationBuilder.AddColumn<string>(
                name: "Participants",
                table: "Group",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "GroupUsers",
                columns: table => new
                {
                    GroupsId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUsers", x => new { x.GroupsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GroupUsers_Group_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUsers_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "Users",
                table: "Group",
                type: "TEXT",
                nullable: true);

            migrationBuilder.DropColumn(
                name: "Participants",
                table: "Group");
        }
    }
}
