using Microsoft.EntityFrameworkCore.Migrations;

namespace Resto.Migrations
{
    public partial class initmenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Menues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menues",
                table: "Menues",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Menues",
                table: "Menues");

            migrationBuilder.RenameTable(
                name: "Menues",
                newName: "Workers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");
        }
    }
}
