using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class changedhappyhourstarttimeandendtimetodataypeDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "hoursOfOperationEndTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "hoursOfOperationEndTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
