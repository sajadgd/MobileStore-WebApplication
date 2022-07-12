using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig7RelationInvoiceWithApplicationUserAndProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Invoice_BuyerUserId",
                table: "Tbl_Invoice",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Invoice_ProductId",
                table: "Tbl_Invoice",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Invoice_Invoice_BuyerUserId",
                table: "Tbl_Invoice",
                column: "Invoice_BuyerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Invoice_Invoice_ProductId",
                table: "Tbl_Invoice",
                column: "Invoice_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Invoice_AspNetUsers_Invoice_BuyerUserId",
                table: "Tbl_Invoice",
                column: "Invoice_BuyerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Invoice_Tbl_Product_Invoice_ProductId",
                table: "Tbl_Invoice",
                column: "Invoice_ProductId",
                principalTable: "Tbl_Product",
                principalColumn: "Product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Invoice_AspNetUsers_Invoice_BuyerUserId",
                table: "Tbl_Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Invoice_Tbl_Product_Invoice_ProductId",
                table: "Tbl_Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Invoice_Invoice_BuyerUserId",
                table: "Tbl_Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Invoice_Invoice_ProductId",
                table: "Tbl_Invoice");

            migrationBuilder.DropColumn(
                name: "Invoice_ProductId",
                table: "Tbl_Invoice");

            migrationBuilder.AlterColumn<string>(
                name: "Invoice_BuyerUserId",
                table: "Tbl_Invoice",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
