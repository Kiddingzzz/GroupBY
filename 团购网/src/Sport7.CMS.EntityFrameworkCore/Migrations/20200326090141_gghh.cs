using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport7.CMS.Migrations
{
    public partial class gghh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeaderImg",
                table: "HouseNews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeaderImg",
                table: "HouseNews");
        }
    }
}
