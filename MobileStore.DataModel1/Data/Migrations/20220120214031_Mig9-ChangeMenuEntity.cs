using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig9ChangeMenuEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Product_Product_MenuId",
                table: "Tbl_Product",
                column: "Product_MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Product_Tbl_Menu_Product_MenuId",
                table: "Tbl_Product",
                column: "Product_MenuId",
                principalTable: "Tbl_Menu",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Product_Tbl_Menu_Product_MenuId",
                table: "Tbl_Product");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Product_Product_MenuId",
                table: "Tbl_Product");
        }
    }
}
