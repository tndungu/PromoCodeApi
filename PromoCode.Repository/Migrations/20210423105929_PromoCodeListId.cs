using Microsoft.EntityFrameworkCore.Migrations;

namespace PromoCode.Repository.Migrations
{
    public partial class PromoCodeListId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PromoCodeListId",
                table: "BonusActivated",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PromoCodeListId",
                table: "BonusActivated");
        }
    }
}
