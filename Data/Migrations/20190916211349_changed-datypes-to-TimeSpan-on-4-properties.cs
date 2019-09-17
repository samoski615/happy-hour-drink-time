using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class changeddatypestoTimeSpanon4properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "happyHourEndTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "hoursOfOperationStartTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                name: "hoursOfOperationEndTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                name: "happyHourStartTime",
                table: "BarOwner",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<string>(
                name: "happyHourEndTime",
                table: "BarOwner",
                nullable: true,
                oldClrType: typeof(TimeSpan));
        }
    }
}
