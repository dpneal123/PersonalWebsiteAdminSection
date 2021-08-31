using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class EventTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventType",
                table: "Event");

            migrationBuilder.AddColumn<int>(
                name: "EventTypeId",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDisplayOrder = table.Column<int>(type: "int", nullable: false),
                    EventTypeActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.EventTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventTypeId",
                table: "Event",
                column: "EventTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_EventType_EventTypeId",
                table: "Event",
                column: "EventTypeId",
                principalTable: "EventType",
                principalColumn: "EventTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_EventType_EventTypeId",
                table: "Event");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropIndex(
                name: "IX_Event_EventTypeId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EventTypeId",
                table: "Event");

            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
