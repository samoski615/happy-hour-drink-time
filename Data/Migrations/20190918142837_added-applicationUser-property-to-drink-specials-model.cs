using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class addedapplicationUserpropertytodrinkspecialsmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationId",
                table: "DrinkSpecials",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
