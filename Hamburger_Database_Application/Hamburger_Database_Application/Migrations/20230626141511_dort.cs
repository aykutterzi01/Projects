using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Database_Application.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_orderLists_OrderListId",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_orderLists_Foods_FoodId",
                table: "orderLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderLists",
                table: "orderLists");

            migrationBuilder.RenameTable(
                name: "orderLists",
                newName: "OrderLists");

            migrationBuilder.RenameIndex(
                name: "IX_orderLists_FoodId",
                table: "OrderLists",
                newName: "IX_OrderLists_FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLists",
                table: "OrderLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_OrderLists_OrderListId",
                table: "Extras",
                column: "OrderListId",
                principalTable: "OrderLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLists_Foods_FoodId",
                table: "OrderLists",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_OrderLists_OrderListId",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLists_Foods_FoodId",
                table: "OrderLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLists",
                table: "OrderLists");

            migrationBuilder.RenameTable(
                name: "OrderLists",
                newName: "orderLists");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLists_FoodId",
                table: "orderLists",
                newName: "IX_orderLists_FoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderLists",
                table: "orderLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_orderLists_OrderListId",
                table: "Extras",
                column: "OrderListId",
                principalTable: "orderLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderLists_Foods_FoodId",
                table: "orderLists",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
