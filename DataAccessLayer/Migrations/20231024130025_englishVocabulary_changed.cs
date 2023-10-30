using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class englishVocabulary_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WordLevel",
                table: "EnglishVocabularies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FrenchStories",
                columns: table => new
                {
                    FrenchStoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrenchStroyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrenchStoryImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrenchStroyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrenchStories", x => x.FrenchStoryID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FrenchStories");

            migrationBuilder.DropColumn(
                name: "WordLevel",
                table: "EnglishVocabularies");
        }
    }
}
