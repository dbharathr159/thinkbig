using Microsoft.EntityFrameworkCore.Migrations;

namespace dummypro.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Orders_Oredrid",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_Oredrid",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "Oredrid",
                table: "Payment");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Orderid",
                table: "Payment",
                column: "Orderid");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Orders_Orderid",
                table: "Payment",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Orders_Orderid",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_Orderid",
                table: "Payment");

            migrationBuilder.AddColumn<int>(
                name: "Oredrid",
                table: "Payment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Oredrid",
                table: "Payment",
                column: "Oredrid");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Orders_Oredrid",
                table: "Payment",
                column: "Oredrid",
                principalTable: "Orders",
                principalColumn: "Orderid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
