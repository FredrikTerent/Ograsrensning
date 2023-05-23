using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgraasApi.Migrations
{
    /// <inheritdoc />
    public partial class allmodelsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cells_Weeds_WeedId",
                table: "Cells");

            migrationBuilder.DropColumn(
                name: "IsWeeded",
                table: "Weeds");

            migrationBuilder.DropColumn(
                name: "IsOccupied",
                table: "Cells");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Weeds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "WeedId",
                table: "Cells",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cells_Weeds_WeedId",
                table: "Cells",
                column: "WeedId",
                principalTable: "Weeds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cells_Weeds_WeedId",
                table: "Cells");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Weeds");

            migrationBuilder.AddColumn<bool>(
                name: "IsWeeded",
                table: "Weeds",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "WeedId",
                table: "Cells",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOccupied",
                table: "Cells",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Cells_Weeds_WeedId",
                table: "Cells",
                column: "WeedId",
                principalTable: "Weeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
