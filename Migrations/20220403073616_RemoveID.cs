using Microsoft.EntityFrameworkCore.Migrations;

namespace NetflixShows.Migrations
{
    public partial class RemoveID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Seriess",
                table: "Seriess");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Seriess");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seriess",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Seriess",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Seriess");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seriess",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Seriess",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seriess",
                table: "Seriess",
                column: "id");
        }
    }
}
