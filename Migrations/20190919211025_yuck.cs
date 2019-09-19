using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Migrations
{
    public partial class yuck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Drinkers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Drinkers",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Drinkers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Drinkers");
        }
    }
}
