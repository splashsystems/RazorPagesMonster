using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMonster.Migrations
{
    public partial class oops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Monster",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Monster",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
