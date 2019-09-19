using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyHourTracker.Data.Migrations
{
    public partial class AddedforeignkeyfieldstoDrinkConsumerClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationId",
                table: "Drinkers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drinkers_ApplicationId",
                table: "Drinkers",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinkers_AspNetUsers_ApplicationId",
                table: "Drinkers",
                column: "ApplicationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinkers_AspNetUsers_ApplicationId",
                table: "Drinkers");

            migrationBuilder.DropIndex(
                name: "IX_Drinkers_ApplicationId",
                table: "Drinkers");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Drinkers");
        }
    }
}
