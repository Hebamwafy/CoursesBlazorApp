using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursesBlazorApp.Migrations
{
    public partial class enrollem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Enrollments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Enrollments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
