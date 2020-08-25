using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AdminAPI.Migrations
{
    public partial class MigrationNew3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenDataTime",
                table: "IPO");

            migrationBuilder.AddColumn<string>(
                name: "OpenDateTime",
                table: "IPO",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenDateTime",
                table: "IPO");

            migrationBuilder.AddColumn<DateTime>(
                name: "OpenDataTime",
                table: "IPO",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
