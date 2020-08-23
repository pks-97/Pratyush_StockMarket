using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AccountAPI.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Board",
                table: "Company",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StockCode",
                table: "Company",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TurnOver",
                table: "Company",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Writeup",
                table: "Company",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Board",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "StockCode",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "TurnOver",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Writeup",
                table: "Company");
        }
    }
}
