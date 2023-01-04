using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApp.Data.Migrations
{
    public partial class SmallThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassId",
                table: "Classes",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Classes_ClassId",
                table: "Classes",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Classes_ClassId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ClassId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Classes");
        }
    }
}
