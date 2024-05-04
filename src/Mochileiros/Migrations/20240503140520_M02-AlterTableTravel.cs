using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mochileiros.Migrations
{
    /// <inheritdoc />
    public partial class M02AlterTableTravel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_User_Mochileiros.Models.Travel_UserId",
                table: "Travel");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_User_TempId_TempId1",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Travel_UserId",
                table: "Travel");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TempId1",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Mochileiros.Models.Travel",
                table: "Travel");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "User",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_Travel_UserId",
                table: "Travel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_User_UserId",
                table: "Travel",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_User_UserId",
                table: "Travel");

            migrationBuilder.DropIndex(
                name: "IX_Travel_UserId",
                table: "Travel");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TempId",
                table: "User",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TempId1",
                table: "User",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mochileiros.Models.Travel",
                table: "Travel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_TempId_TempId1",
                table: "User",
                columns: new[] { "TempId", "TempId1" });

            migrationBuilder.CreateIndex(
                name: "IX_Travel_UserId",
                table: "Travel",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_User_Mochileiros.Models.Travel_UserId",
                table: "Travel",
                columns: new[] { "Mochileiros.Models.Travel", "UserId" },
                principalTable: "User",
                principalColumns: new[] { "TempId", "TempId1" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
