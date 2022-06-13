using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingWebApi.Migrations
{
    public partial class UpdateReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "product_id",
                table: "order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "order",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
