using Microsoft.EntityFrameworkCore.Migrations;

namespace Resto.Migrations
{
    public partial class item : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_shortinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal_price = table.Column<decimal>(type: "Money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
