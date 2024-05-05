using Microsoft.EntityFrameworkCore.Migrations;

namespace Mochileiros.Migrations
{
    public partial class AddTravelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Travel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
                
    migrationBuilder.CreateIndex(
        name: "IX_Travel_UserId",
        table: "Travel",
        column: "UserId");

    migrationBuilder.AddForeignKey(
        name: "FK_Travel_Users_UserId",
        table: "Travel",
        column: "UserId",
        principalTable: "Users",
        principalColumn: "Id",
        onDelete: ReferentialAction.Cascade);
}


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_Users_UserId",
                table: "Travel");

            migrationBuilder.DropIndex(
                name: "IX_Travel_UserId",
                table: "Travel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Travel");
        }
    }
}

