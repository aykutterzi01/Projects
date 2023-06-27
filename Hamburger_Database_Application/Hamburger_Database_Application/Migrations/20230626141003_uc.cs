using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger_Database_Application.Migrations
{
    public partial class uc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderListId",
                table: "Extras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "orderLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    FoodQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderLists_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Extras_OrderListId",
                table: "Extras",
                column: "OrderListId");

            migrationBuilder.CreateIndex(
                name: "IX_orderLists_FoodId",
                table: "orderLists",
                column: "FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_orderLists_OrderListId",
                table: "Extras",
                column: "OrderListId",
                principalTable: "orderLists",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_orderLists_OrderListId",
                table: "Extras");

            migrationBuilder.DropTable(
                name: "orderLists");

            migrationBuilder.DropIndex(
                name: "IX_Extras_OrderListId",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "OrderListId",
                table: "Extras");
        }
    }
}
