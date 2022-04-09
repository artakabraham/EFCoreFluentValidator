using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class AddEmailInCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Customer",
                newName: "Phone");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customer",
                newName: "MyProperty");
        }
    }
}
