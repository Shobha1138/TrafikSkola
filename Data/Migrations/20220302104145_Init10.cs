using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafikSkola.Data.Migrations
{
    public partial class Init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "Learners",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "Learners");
        }
    }
}
