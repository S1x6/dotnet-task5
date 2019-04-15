using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTask4.Migrations
{
    public partial class Age : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Employees",
                nullable: false,
                defaultValue: 18);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees");
        }
    }
}
