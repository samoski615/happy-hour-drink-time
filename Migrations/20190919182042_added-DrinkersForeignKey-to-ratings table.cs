using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Migrations
{
    public partial class addedDrinkersForeignKeytoratingstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrinkConsumersId",
                table: "RatingsTable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DrinkersId",
                table: "RatingsTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RatingsTable_DrinkConsumersId",
                table: "RatingsTable",
                column: "DrinkConsumersId");

            migrationBuilder.AddForeignKey(
                name: "FK_RatingsTable_Drinkers_DrinkConsumersId",
                table: "RatingsTable",
                column: "DrinkConsumersId",
                principalTable: "Drinkers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingsTable_Drinkers_DrinkConsumersId",
                table: "RatingsTable");

            migrationBuilder.DropIndex(
                name: "IX_RatingsTable_DrinkConsumersId",
                table: "RatingsTable");

            migrationBuilder.DropColumn(
                name: "DrinkConsumersId",
                table: "RatingsTable");

            migrationBuilder.DropColumn(
                name: "DrinkersId",
                table: "RatingsTable");
        }
    }
}
