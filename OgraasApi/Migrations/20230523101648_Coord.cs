using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgraasApi.Migrations
{
    /// <inheritdoc />
    public partial class Coord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Weeds");

            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardId = table.Column<int>(type: "int", nullable: false),
                    row = table.Column<int>(type: "int", nullable: false),
                    col = table.Column<int>(type: "int", nullable: false),
                    cellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinates_Cells_cellId",
                        column: x => x.cellId,
                        principalTable: "Cells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_BoardId",
                table: "Players",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_cellId",
                table: "Coordinates",
                column: "cellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Boards_BoardId",
                table: "Players",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Boards_BoardId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropIndex(
                name: "IX_Players_BoardId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Weeds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
