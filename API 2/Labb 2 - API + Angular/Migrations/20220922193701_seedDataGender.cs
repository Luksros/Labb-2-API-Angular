using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___API___Angular.Migrations
{
    public partial class seedDataGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "GenderName" },
                values: new object[] { 1, "Female" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "GenderName" },
                values: new object[] { 2, "Male" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "ID", "GenderName" },
                values: new object[] { 3, "Other" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
