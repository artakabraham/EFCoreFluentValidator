using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class UpdateCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Customer",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Customer");
        }
    }
}
