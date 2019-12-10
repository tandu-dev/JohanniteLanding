using Microsoft.EntityFrameworkCore.Migrations;

namespace JohanniteLanding.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Href = table.Column<string>(nullable: true),
                    displayName = table.Column<string>(nullable: true),
                    ImageLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "Href", "ImageLink", "displayName" },
                values: new object[] { 1, "https://office.johannite.tech", null, "Divine Office of the Apostolic Johannite Church" });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "Href", "ImageLink", "displayName" },
                values: new object[] { 2, "https://lectionary.johannite.tech", null, "The Lectionary of the Apostolic Johannite Church" });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "Href", "ImageLink", "displayName" },
                values: new object[] { 3, "https://johannite.org", null, "The Apostolic Johannite Church" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}
