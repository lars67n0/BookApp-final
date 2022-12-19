using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApp.Data.Migrations
{
    public partial class AddedEducation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Koordinators",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Courses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Classes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Koordinators",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "id");
        }
    }
}
