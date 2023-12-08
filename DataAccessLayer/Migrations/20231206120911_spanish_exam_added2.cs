using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class spanish_exam_added2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpanishExamContents",
                columns: table => new
                {
                    SpanishExamContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpanishExamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishExamOptionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishExamOptionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishExamOptionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishExamOptionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishExamCorrect = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpanishExamContents", x => x.SpanishExamContentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpanishExamContents");
        }
    }
}
