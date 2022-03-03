using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafikSkola.Data.Migrations
{
    public partial class Init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Drivers",
                newName: "VechicalType");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Drivers",
                newName: "FileName");

            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Drivers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "VechicalType",
                table: "Drivers",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Drivers",
                newName: "ImageUrl");
        }
    }
}
