using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondHand.Migrations
{
    public partial class RegisterUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_City_UserCitycityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserCitycityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCitycityId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserCityId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserCityId",
                table: "AspNetUsers",
                column: "UserCityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_City_UserCityId",
                table: "AspNetUsers",
                column: "UserCityId",
                principalTable: "City",
                principalColumn: "cityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_City_UserCityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserCityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserCityId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserCitycityId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserCitycityId",
                table: "AspNetUsers",
                column: "UserCitycityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_City_UserCitycityId",
                table: "AspNetUsers",
                column: "UserCitycityId",
                principalTable: "City",
                principalColumn: "cityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
