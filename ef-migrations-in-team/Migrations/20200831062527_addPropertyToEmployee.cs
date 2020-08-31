using Microsoft.EntityFrameworkCore.Migrations;

namespace ef_migrations_in_team.Migrations
{
    public partial class addPropertyToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bla",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bla",
                table: "Employees");
        }
    }
}
