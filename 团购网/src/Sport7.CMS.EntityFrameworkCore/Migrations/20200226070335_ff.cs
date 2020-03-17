using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport7.CMS.Migrations
{
    public partial class ff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VTImg",
                table: "HouseInfer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VTImg",
                table: "HouseInfer");
        }
    }
}
