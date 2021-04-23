using Microsoft.EntityFrameworkCore.Migrations;

namespace PromoCode.Repository.Migrations
{
    public partial class promos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PromoCodeProduct",
                newName: "ProductDescription");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "PromoCodeProduct",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "PromoCodeProduct");

            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "PromoCodeProduct",
                newName: "Description");
        }
    }
}
