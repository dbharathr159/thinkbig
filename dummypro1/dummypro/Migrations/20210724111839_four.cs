using Microsoft.EntityFrameworkCore.Migrations;

namespace dummypro.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_Orderid",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customer_Customerid",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Customerid",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_Menuid",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_Orderid",
                table: "OrderItem");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "OrderItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "OrderItem");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customerid",
                table: "Orders",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Menuid",
                table: "OrderItem",
                column: "Menuid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Orderid",
                table: "OrderItem",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Menu_Menuid",
                table: "OrderItem",
                column: "Menuid",
                principalTable: "Menu",
                principalColumn: "Menuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_Orderid",
                table: "OrderItem",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customer_Customerid",
                table: "Orders",
                column: "Customerid",
                principalTable: "Customer",
                principalColumn: "Customerid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
