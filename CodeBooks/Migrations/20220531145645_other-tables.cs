using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBooks.Migrations
{
    public partial class othertables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yetkiLvl",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yetkiLvl",
                table: "Admins");
        }
    }
}
