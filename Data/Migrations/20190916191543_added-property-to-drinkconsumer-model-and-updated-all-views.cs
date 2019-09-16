using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedpropertytodrinkconsumermodelandupdatedallviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Drinkers");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Drinkers",
                newName: "zipcode");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Drinkers",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Drinkers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Drinkers",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Drinkers",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Drinkers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Drinkers",
                newName: "favoriteBarType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "zipcode",
                table: "Drinkers",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Drinkers",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Drinkers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Drinkers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Drinkers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "favoriteBarType",
                table: "Drinkers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Drinkers",
                newName: "StreetAddress");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Drinkers",
                nullable: true);
        }
    }
}
