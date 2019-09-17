using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class changedTimeSpandatatypesbacktostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "hoursOfOperationStartTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<string>(
                name: "hoursOfOperationEndTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<string>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<string>(
                name: "happyHourEndTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(TimeSpan));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "hoursOfOperationStartTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "hoursOfOperationEndTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "happyHourEndTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
