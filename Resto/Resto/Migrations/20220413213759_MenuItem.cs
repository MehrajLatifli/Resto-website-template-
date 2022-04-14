using Microsoft.EntityFrameworkCore.Migrations;

namespace Resto.Migrations
{
    public partial class MenuItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Meal_image",
                table: "Menues",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Meal_image",
                table: "Menues");
        }
    }
}
