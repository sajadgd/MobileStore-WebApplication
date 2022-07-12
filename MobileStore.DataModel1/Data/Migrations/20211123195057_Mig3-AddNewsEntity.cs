using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig3AddNewsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_News",
                columns: table => new
                {
                    News_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    News_Title = table.Column<string>(maxLength: 100, nullable: false),
                    News_Description = table.Column<string>(maxLength: 500, nullable: false),
                    News_Image = table.Column<string>(nullable: false),
                    News_IsAccept = table.Column<bool>(nullable: false),
                    News_RegistrationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_News", x => x.News_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_News");
        }
    }
}
