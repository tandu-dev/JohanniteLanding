using Microsoft.EntityFrameworkCore.Migrations;

namespace JohanniteLanding.Data.Migrations
{
    public partial class Active : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Links",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "LinkId",
                keyValue: 3,
                column: "Active",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Links");
        }
    }
}
