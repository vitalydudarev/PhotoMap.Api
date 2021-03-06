using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotoMap.Api.Migrations
{
    public partial class DeletedDropboxColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DropboxStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DropboxToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DropboxTokenExpiresOn",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DropboxStatus",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DropboxToken",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DropboxTokenExpiresOn",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
