using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class pulledupdatedworktoworkoffof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bar");

            migrationBuilder.DropColumn(
                name: "MainTypeOfAlcohol",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "TimeHappyHourEnds",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "TimeHappyHourStarts",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "favoriteBarType",
                table: "Drinkers");

            migrationBuilder.RenameColumn(
                name: "TypeOfdrink",
                table: "DrinkSpecials",
                newName: "TypeOfDrink");

            migrationBuilder.RenameColumn(
                name: "zipcode",
                table: "Drinkers",
                newName: "Zipcode");

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
                name: "address",
                table: "Drinkers",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "BarOwners",
                newName: "TypeOfBar");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "BarOwners",
                newName: "State");

            migrationBuilder.AlterColumn<int>(
                name: "DayOfTheWeek",
                table: "DrinkSpecials",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HappyHourEndTime",
                table: "DrinkSpecials",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HappyHourStartTime",
                table: "DrinkSpecials",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Drinkers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "CheckinStatus",
                table: "Drinkers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BarOwners",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BarClose",
                table: "BarOwners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BarName",
                table: "BarOwners",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BarOpen",
                table: "BarOwners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "BarOwners",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PotentialCustomers",
                table: "BarOwners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "BarOwners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Zipcode",
                table: "BarOwners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_DrinkSpecials_ApplicationId",
                table: "DrinkSpecials",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkSpecials_AspNetUsers_ApplicationId",
                table: "DrinkSpecials",
                column: "ApplicationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkSpecials_AspNetUsers_ApplicationId",
                table: "DrinkSpecials");

            migrationBuilder.DropIndex(
                name: "IX_DrinkSpecials_ApplicationId",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "HappyHourEndTime",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "HappyHourStartTime",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "CheckinStatus",
                table: "Drinkers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "BarClose",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "BarName",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "BarOpen",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "City",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "PotentialCustomers",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "BarOwners");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TypeOfDrink",
                table: "DrinkSpecials",
                newName: "TypeOfdrink");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
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
                name: "Address",
                table: "Drinkers",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "TypeOfBar",
                table: "BarOwners",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "BarOwners",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "DayOfTheWeek",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainTypeOfAlcohol",
                table: "DrinkSpecials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeHappyHourEnds",
                table: "DrinkSpecials",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeHappyHourStarts",
                table: "DrinkSpecials",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "zipcode",
                table: "Drinkers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "favoriteBarType",
                table: "Drinkers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(nullable: true),
                    atmosphere = table.Column<string>(nullable: true),
                    barName = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    hoursOfOperationEndTime = table.Column<string>(nullable: true),
                    hoursOfOperationStartTime = table.Column<string>(nullable: true),
                    potentialCustomers = table.Column<int>(nullable: false),
                    rating = table.Column<int>(nullable: false),
                    state = table.Column<string>(nullable: true),
                    zipcode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bar", x => x.Id);
                });
        }
    }
}
