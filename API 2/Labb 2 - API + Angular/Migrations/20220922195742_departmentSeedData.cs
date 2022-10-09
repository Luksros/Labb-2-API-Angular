using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___API___Angular.Migrations
{
    public partial class departmentSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "DepartmentName" },
                values: new object[] { 1, "Finance" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
