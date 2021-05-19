using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Server.Data.Migrations
{
    public partial class AddedUniqueNameToProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueName",
                table: "Products");
        }
    }
}
