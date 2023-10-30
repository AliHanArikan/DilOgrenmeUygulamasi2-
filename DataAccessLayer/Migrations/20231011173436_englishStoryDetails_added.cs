using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class englishStoryDetails_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnglishStoryDetails",
                columns: table => new
                {
                    EnglishStoryDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishStoryDetailsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishStoryImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishStoryDetailsContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishStoryDetails", x => x.EnglishStoryDetailsID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishStoryDetails");
        }
    }
}
