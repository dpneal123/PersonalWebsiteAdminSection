using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class ImagesUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Image",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ImageData",
                table: "Image",
                newName: "ImageFile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Image",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "Image",
                newName: "ImageData");
        }
    }
}
