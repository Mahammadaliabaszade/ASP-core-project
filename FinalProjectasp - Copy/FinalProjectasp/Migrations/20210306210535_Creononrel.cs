using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectasp.Migrations
{
    public partial class Creononrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseDetailId",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_courseDetails_CourseId",
                table: "courseDetails",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_courseDetails_Courses_CourseId",
                table: "courseDetails",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseDetails_Courses_CourseId",
                table: "courseDetails");

            migrationBuilder.DropIndex(
                name: "IX_courseDetails_CourseId",
                table: "courseDetails");

            migrationBuilder.AddColumn<int>(
                name: "CourseDetailId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
