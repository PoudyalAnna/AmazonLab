using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcApplication.Data.Migrations
{
    public partial class ReleaseDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RekeaseData",
                table: "Music",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RekeaseData",
                table: "Music");
        }
    }
}
