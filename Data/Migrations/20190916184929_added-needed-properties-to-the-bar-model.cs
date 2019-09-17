using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedneededpropertiestothebarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "priceRange",
                table: "Bar",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "hours",
                table: "Bar",
                newName: "hoursOfOperationStartTime");

            migrationBuilder.RenameColumn(
                name: "drinkSpecials",
                table: "Bar",
                newName: "hoursOfOperationEndTime");

            migrationBuilder.AddColumn<string>(
                name: "happyHourEndTime",
                table: "Bar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "happyHourStartTime",
                table: "Bar",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "potentialCusotmers",
                table: "Bar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "happyHourEndTime",
                table: "Bar");

            migrationBuilder.DropColumn(
                name: "happyHourStartTime",
                table: "Bar");

            migrationBuilder.DropColumn(
                name: "potentialCusotmers",
                table: "Bar");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Bar",
                newName: "priceRange");

            migrationBuilder.RenameColumn(
                name: "hoursOfOperationStartTime",
                table: "Bar",
                newName: "hours");

            migrationBuilder.RenameColumn(
                name: "hoursOfOperationEndTime",
                table: "Bar",
                newName: "drinkSpecials");
        }
    }
}
