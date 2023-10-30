using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class exam_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnglishExamContents",
                columns: table => new
                {
                    EnglishExamContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishExamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishExamOptionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishExamOptionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishExamOptionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishExamOptionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishExamCorrect = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishExamContents", x => x.EnglishExamContentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishExamContents");
        }
    }
}
