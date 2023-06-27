using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Database_Application.Migrations
{
    public partial class bes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtraNames",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraNames",
                table: "OrderLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraNames",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ExtraNames",
                table: "OrderLists");
        }
    }
}
