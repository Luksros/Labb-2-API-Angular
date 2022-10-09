using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___API___Angular.Migrations
{
    public partial class employeeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "DepartmentID", "FirstName", "GenderID", "LastName" },
                values: new object[] { 1, 1, "Lukas", 2, "Rose" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
