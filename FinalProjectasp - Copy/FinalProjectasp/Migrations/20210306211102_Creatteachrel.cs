using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectasp.Migrations
{
    public partial class Creatteachrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherDetailID",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "TeacherDetails",
                newName: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.DropIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "TeacherDetails",
                newName: "TeacherID");

            migrationBuilder.AddColumn<int>(
                name: "TeacherDetailID",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
