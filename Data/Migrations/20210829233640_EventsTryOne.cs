using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class EventsTryOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishEvent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
