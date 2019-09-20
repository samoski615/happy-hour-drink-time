using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Migrations
{
    public partial class renamedDrinkersIdproptoDrinkConsumersId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingsTable_Drinkers_DrinkConsumersId",
                table: "RatingsTable");

            migrationBuilder.DropColumn(
                name: "DrinkersId",
                table: "RatingsTable");

            migrationBuilder.AlterColumn<int>(
                name: "DrinkConsumersId",
                table: "RatingsTable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RatingsTable_Drinkers_DrinkConsumersId",
                table: "RatingsTable",
                column: "DrinkConsumersId",
                principalTable: "Drinkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingsTable_Drinkers_DrinkConsumersId",
                table: "RatingsTable");

            migrationBuilder.AlterColumn<int>(
                name: "DrinkConsumersId",
                table: "RatingsTable",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DrinkersId",
                table: "RatingsTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_RatingsTable_Drinkers_DrinkConsumersId",
                table: "RatingsTable",
                column: "DrinkConsumersId",
                principalTable: "Drinkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
