using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetflixShows.Migrations
{
    public partial class AddGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Seriess",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seriess",
                table: "Seriess",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Seriess",
                table: "Seriess");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Seriess");
        }
    }
}
