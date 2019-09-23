using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcApplication.Data.Migrations
{
    public partial class SongURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SongURL",
                table: "Song",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SongURL",
                table: "Song");
        }
    }
}
