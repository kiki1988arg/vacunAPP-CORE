using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class updateFunctionPRofesional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Profesional",
                keyColumn: "Id",
                keyValue: 3,
                column: "Function",
                value: "P");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Profesional",
                keyColumn: "Id",
                keyValue: 3,
                column: "Function",
                value: "Profesional");
        }
    }
}
