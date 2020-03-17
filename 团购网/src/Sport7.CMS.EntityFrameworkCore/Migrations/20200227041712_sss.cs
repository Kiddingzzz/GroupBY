using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport7.CMS.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HuxingImg",
                table: "HouseInfer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Peitaotu",
                table: "HouseInfer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shijingtu",
                table: "HouseInfer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shoulouchu",
                table: "HouseInfer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zhengzhao",
                table: "HouseInfer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HuxingImg",
                table: "HouseInfer");

            migrationBuilder.DropColumn(
                name: "Peitaotu",
                table: "HouseInfer");

            migrationBuilder.DropColumn(
                name: "Shijingtu",
                table: "HouseInfer");

            migrationBuilder.DropColumn(
                name: "Shoulouchu",
                table: "HouseInfer");

            migrationBuilder.DropColumn(
                name: "Zhengzhao",
                table: "HouseInfer");
        }
    }
}
