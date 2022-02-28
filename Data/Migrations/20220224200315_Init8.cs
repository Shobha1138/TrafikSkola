using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafikSkola.Data.Migrations
{
    public partial class Init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specliazation",
                table: "Drivers",
                newName: "Skills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Drivers",
                newName: "Specliazation");
        }
    }
}
