using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectasp.Migrations
{
    public partial class Createspeaker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Speakers_EventDetailId",
                table: "Speakers",
                column: "EventDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Speakers_EventDetails_EventDetailId",
                table: "Speakers",
                column: "EventDetailId",
                principalTable: "EventDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Speakers_EventDetails_EventDetailId",
                table: "Speakers");

            migrationBuilder.DropIndex(
                name: "IX_Speakers_EventDetailId",
                table: "Speakers");
        }
    }
}
