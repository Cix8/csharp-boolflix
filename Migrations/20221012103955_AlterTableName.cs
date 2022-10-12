using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class AlterTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Pegis_PegiId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_TVSeries_Pegis_PegiId",
                table: "TVSeries");

            migrationBuilder.DropTable(
                name: "Pegis");

            migrationBuilder.DropIndex(
                name: "IX_TVSeries_PegiId",
                table: "TVSeries");

            migrationBuilder.DropIndex(
                name: "IX_Films_PegiId",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "ClassificationId",
                table: "TVSeries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassificationId",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TVSeries_ClassificationId",
                table: "TVSeries",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_ClassificationId",
                table: "Films",
                column: "ClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Classifications_ClassificationId",
                table: "Films",
                column: "ClassificationId",
                principalTable: "Classifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TVSeries_Classifications_ClassificationId",
                table: "TVSeries",
                column: "ClassificationId",
                principalTable: "Classifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Classifications_ClassificationId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_TVSeries_Classifications_ClassificationId",
                table: "TVSeries");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropIndex(
                name: "IX_TVSeries_ClassificationId",
                table: "TVSeries");

            migrationBuilder.DropIndex(
                name: "IX_Films_ClassificationId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "ClassificationId",
                table: "TVSeries");

            migrationBuilder.DropColumn(
                name: "ClassificationId",
                table: "Films");

            migrationBuilder.CreateTable(
                name: "Pegis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pegis", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TVSeries_PegiId",
                table: "TVSeries",
                column: "PegiId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_PegiId",
                table: "Films",
                column: "PegiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Pegis_PegiId",
                table: "Films",
                column: "PegiId",
                principalTable: "Pegis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TVSeries_Pegis_PegiId",
                table: "TVSeries",
                column: "PegiId",
                principalTable: "Pegis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
