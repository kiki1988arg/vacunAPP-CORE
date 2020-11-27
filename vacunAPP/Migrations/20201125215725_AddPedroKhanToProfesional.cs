using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddPedroKhanToProfesional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profesional",
                columns: new[] { "Id", "Email", "Function", "InstituteId", "LastName", "MN", "NIF", "Name", "Password" },
                values: new object[] { 3, "Pedro@Kahn.com", "Profesional", 999999, "Kahn", "5132135", "5132135", "Pedro", "Pedro@Kahn.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profesional",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
