using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extra",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Large",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Medium",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Small",
                table: "Carts",
                newName: "Quantity");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Carts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Carts",
                newName: "Small");

            migrationBuilder.AddColumn<int>(
                name: "Extra",
                table: "Carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Large",
                table: "Carts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Medium",
                table: "Carts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
