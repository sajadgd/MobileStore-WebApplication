using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileStore.DataModelLayer1.Data.Migrations
{
    public partial class Mig4AddSettingsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Settings",
                columns: table => new
                {
                    Settings_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Settings_SiteName = table.Column<string>(nullable: true),
                    Settings_About = table.Column<string>(nullable: true),
                    Settings_Tel = table.Column<string>(nullable: true),
                    Settings_Fax = table.Column<string>(nullable: true),
                    Settings_Email = table.Column<string>(nullable: true),
                    Settings_Address = table.Column<int>(nullable: false),
                    Settings_MetaKeyword = table.Column<int>(nullable: false),
                    Settings_Description = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Settings", x => x.Settings_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Settings");
        }
    }
}
