using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectasp.Migrations
{
    public partial class Crerelevedetai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDetailId",
                table: "Events");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetails_EventId",
                table: "EventDetails",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDetails_Events_EventId",
                table: "EventDetails",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventDetails_Events_EventId",
                table: "EventDetails");

            migrationBuilder.DropIndex(
                name: "IX_EventDetails_EventId",
                table: "EventDetails");

            migrationBuilder.AddColumn<int>(
                name: "EventDetailId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
