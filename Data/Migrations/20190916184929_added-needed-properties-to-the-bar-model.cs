using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedneededpropertiestothebarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "priceRange",
                table: "BarOwner",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "hours",
                table: "BarOwner",
                newName: "hoursOfOperationStartTime");

            migrationBuilder.RenameColumn(
                name: "drinkSpecials",
                table: "BarOwner",
                newName: "hoursOfOperationEndTime");

            migrationBuilder.AddColumn<string>(
                name: "happyHourEndTime",
                table: "BarOwner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "potentialCusotmers",
                table: "BarOwner",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "happyHourEndTime",
                table: "BarOwner");

            migrationBuilder.DropColumn(
                name: "happyHourStartTime",
                table: "BarOwner");

            migrationBuilder.DropColumn(
                name: "potentialCusotmers",
                table: "BarOwner");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "BarOwner",
                newName: "priceRange");

            migrationBuilder.RenameColumn(
                name: "hoursOfOperationStartTime",
                table: "BarOwner",
                newName: "hours");

            migrationBuilder.RenameColumn(
                name: "hoursOfOperationEndTime",
                table: "BarOwner",
                newName: "drinkSpecials");
        }
    }
}
