using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ChangedColourId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Colour_ColourId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryColourId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "ColourId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Colour_ColourId",
                table: "Category",
                column: "ColourId",
                principalTable: "Colour",
                principalColumn: "ColourId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Colour_ColourId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "ColourId",
                table: "Category",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryColourId",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Colour_ColourId",
                table: "Category",
                column: "ColourId",
                principalTable: "Colour",
                principalColumn: "ColourId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
