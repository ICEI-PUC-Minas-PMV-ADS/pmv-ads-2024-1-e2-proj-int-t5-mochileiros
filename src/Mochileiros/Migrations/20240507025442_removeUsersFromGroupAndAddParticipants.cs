using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mochileiros.Migrations
{
    public partial class RemoveUsersAndChangeToParticipants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        

            migrationBuilder.AddColumn<string>(
                name: "Participants",
                table: "Group",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Participants",
                table: "Group");
        }
    }
}
