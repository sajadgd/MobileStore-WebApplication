using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig6AddCatAndMenuEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_SubMenu",
                table: "Tbl_Product");

            migrationBuilder.AddColumn<int>(
                name: "Product_MenuId",
                table: "Tbl_Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tbl_Categories",
                columns: table => new
                {
                    CategoriesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesTitle = table.Column<string>(nullable: true),
                    CategoriesParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Categories", x => x.CategoriesID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTitle = table.Column<string>(nullable: true),
                    CateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Menu", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Tbl_Menu_Tbl_Categories_CateId",
                        column: x => x.CateId,
                        principalTable: "Tbl_Categories",
                        principalColumn: "CategoriesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Menu_CateId",
                table: "Tbl_Menu",
                column: "CateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Menu");

            migrationBuilder.DropTable(
                name: "Tbl_Categories");

            migrationBuilder.DropColumn(
                name: "Product_MenuId",
                table: "Tbl_Product");

            migrationBuilder.AddColumn<int>(
                name: "Product_SubMenu",
                table: "Tbl_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
