using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class AlterPegiTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pegis");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Pegis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Pegis");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pegis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
