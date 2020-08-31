using Microsoft.EntityFrameworkCore.Migrations;

namespace ef_migrations_in_team.Migrations
{
    public partial class AddReadersProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Readers",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Readers",
                table: "Blogs");
        }
    }
}
