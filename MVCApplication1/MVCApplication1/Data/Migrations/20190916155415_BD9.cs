using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCApplication1.Data.Migrations
{
    public partial class BD9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteGenre",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteGenre",
                table: "Customers");
        }
    }
}
