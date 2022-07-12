using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig8AddProductDetailEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_ProductDetail",
                columns: table => new
                {
                    ProductDetail_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDetail_AttName = table.Column<string>(nullable: false),
                    ProductDetail_AttValue = table.Column<string>(nullable: true),
                    ProductDetail_ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductDetail", x => x.ProductDetail_Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductDetail_Tbl_Product_ProductDetail_ProductId",
                        column: x => x.ProductDetail_ProductId,
                        principalTable: "Tbl_Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductDetail_ProductDetail_ProductId",
                table: "Tbl_ProductDetail",
                column: "ProductDetail_ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_ProductDetail");
        }
    }
}
