using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class fixedpropertytypoforpotentialCustomersandchangeddataTypeforsaidproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "potentialCusotmers",
                table: "Bar");

            migrationBuilder.AddColumn<string>(
                name: "potentialCustomers",
                table: "Bar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "potentialCustomers",
                table: "Bar");

            migrationBuilder.AddColumn<int>(
                name: "potentialCusotmers",
                table: "Bar",
                nullable: false,
                defaultValue: 0);
        }
    }
}
