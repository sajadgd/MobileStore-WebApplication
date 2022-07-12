using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig2AddProductEntityAndProductGalleryEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ProName = table.Column<string>(maxLength: 100, nullable: false),
                    Product_NameEn = table.Column<string>(maxLength: 100, nullable: false),
                    Product_TozihKotah = table.Column<string>(maxLength: 150, nullable: false),
                    Product_TozihKamel = table.Column<string>(nullable: false),
                    Product_Code = table.Column<string>(maxLength: 10, nullable: false),
                    Product_Bazdid = table.Column<int>(nullable: false),
                    Product_Mojodi = table.Column<int>(nullable: false),
                    Product_Takhfif = table.Column<double>(nullable: false),
                    Product_ZamanSabt = table.Column<DateTime>(nullable: false),
                    Product_Mablagh = table.Column<double>(nullable: false),
                    Product_SubMenu = table.Column<int>(nullable: false),
                    Product_IsAccept = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Product", x => x.Product_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductGallery",
                columns: table => new
                {
                    ProductGallery_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGallery_Name = table.Column<string>(nullable: true),
                    ProductGallery_ProductId = table.Column<int>(nullable: false),
                    ProductGallery_Default = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductGallery", x => x.ProductGallery_Id);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductGallery_Tbl_Product_ProductGallery_ProductId",
                        column: x => x.ProductGallery_ProductId,
                        principalTable: "Tbl_Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductGallery_ProductGallery_ProductId",
                table: "Tbl_ProductGallery",
                column: "ProductGallery_ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_ProductGallery");

            migrationBuilder.DropTable(
                name: "Tbl_Product");
        }
    }
}
