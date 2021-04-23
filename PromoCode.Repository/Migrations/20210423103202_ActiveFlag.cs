using Microsoft.EntityFrameworkCore.Migrations;

namespace PromoCode.Repository.Migrations
{
    public partial class ActiveFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ActiveFlag",
                table: "BonusActivated",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveFlag",
                table: "BonusActivated");
        }
    }
}
