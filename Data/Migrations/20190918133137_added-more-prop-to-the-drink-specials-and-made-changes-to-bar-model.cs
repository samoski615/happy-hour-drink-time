using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedmoreproptothedrinkspecialsandmadechangestobarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkSpecials_AspNetUsers_ApplicationId",
                table: "DrinkSpecials");

            migrationBuilder.DropIndex(
                name: "IX_DrinkSpecials_ApplicationId",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "happyHourEndTime",
                table: "Bar");

            migrationBuilder.DropColumn(
                name: "happyHourStartTime",
                table: "Bar");

            migrationBuilder.RenameColumn(
                name: "drink",
                table: "DrinkSpecials",
                newName: "TypeOfdrink");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DayOfTheWeek",
                table: "DrinkSpecials",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DrinkPrice",
                table: "DrinkSpecials",
                nullable: false,
                defaultValue: 0.0);

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
                name: "potentialCustomers",
                table: "Bar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "hoursOfOperationStartTime",
                table: "Bar",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "hoursOfOperationEndTime",
                table: "Bar",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfTheWeek",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "DrinkPrice",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "MainTypeOfAlcohol",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "TimeHappyHourEnds",
                table: "DrinkSpecials");

            migrationBuilder.DropColumn(
                name: "TimeHappyHourStarts",
                table: "DrinkSpecials");

            migrationBuilder.RenameColumn(
                name: "TypeOfdrink",
                table: "DrinkSpecials",
                newName: "drink");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "potentialCustomers",
                table: "Bar",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "hoursOfOperationStartTime",
                table: "Bar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "hoursOfOperationEndTime",
                table: "Bar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "happyHourEndTime",
                table: "Bar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "happyHourStartTime",
                table: "Bar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
