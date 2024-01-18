using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    public partial class mig_cardetail_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carDetails_AspNetUsers_appuserId",
                table: "carDetails");

            migrationBuilder.DropColumn(
                name: "AppUser",
                table: "carDetails");

            migrationBuilder.RenameColumn(
                name: "appuserId",
                table: "carDetails",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_carDetails_appuserId",
                table: "carDetails",
                newName: "IX_carDetails_AppUserID");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdDate",
                table: "carDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_carDetails_AspNetUsers_AppUserID",
                table: "carDetails",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carDetails_AspNetUsers_AppUserID",
                table: "carDetails");

            migrationBuilder.DropColumn(
                name: "createdDate",
                table: "carDetails");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "carDetails",
                newName: "appuserId");

            migrationBuilder.RenameIndex(
                name: "IX_carDetails_AppUserID",
                table: "carDetails",
                newName: "IX_carDetails_appuserId");

            migrationBuilder.AddColumn<int>(
                name: "AppUser",
                table: "carDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_carDetails_AspNetUsers_appuserId",
                table: "carDetails",
                column: "appuserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
