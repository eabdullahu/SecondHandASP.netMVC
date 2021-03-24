using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondHand.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UserRegisterDate",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserLastname",
                table: "AspNetUsers",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserFirstname",
                table: "AspNetUsers",
                maxLength: 105,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(105)",
                oldMaxLength: 105,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UserDOB",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserCitycityId",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserAddress",
                table: "AspNetUsers",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserRegisterDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "UserLastname",
                table: "AspNetUsers",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<string>(
                name: "UserFirstname",
                table: "AspNetUsers",
                type: "nvarchar(105)",
                maxLength: 105,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 105);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UserDOB",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "UserCitycityId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserAddress",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
