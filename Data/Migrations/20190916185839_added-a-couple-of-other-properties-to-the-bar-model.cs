using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedacoupleofotherpropertiestothebarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "BarOwner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "BarOwner",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "zipcode",
                table: "BarOwner",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "BarOwner");

            migrationBuilder.DropColumn(
                name: "state",
                table: "BarOwner");

            migrationBuilder.DropColumn(
                name: "zipcode",
                table: "BarOwner");

            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
