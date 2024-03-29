﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCApplication1.Data.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Song",
                table: "Song");

            migrationBuilder.RenameTable(
                name: "Song",
                newName: "Songs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "Song");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song",
                table: "Song",
                column: "Id");
        }
    }
}
