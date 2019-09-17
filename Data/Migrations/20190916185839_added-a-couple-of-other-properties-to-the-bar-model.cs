using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedacoupleofotherpropertiestothebarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "Bar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Bar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Bar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "zipcode",
                table: "Bar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "Bar");

            migrationBuilder.DropColumn(
                name: "state",
                table: "Bar");

            migrationBuilder.DropColumn(
                name: "zipcode",
                table: "Bar");

            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "Bar",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
