using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class spanish_storydetail_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "spanishStoryDetails",
                columns: table => new
                {
                    SpanishStoryDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpanishStoryDetailsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpanishStoryImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpanishStoryDetailsContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spanishStoryDetails", x => x.SpanishStoryDetailID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "spanishStoryDetails");
        }
    }
}
