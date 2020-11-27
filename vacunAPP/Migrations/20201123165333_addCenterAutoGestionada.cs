using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class addCenterAutoGestionada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Center",
                columns: new[] { "Id", "Address", "InstituteId", "Lat", "Locale", "Long", "Name", "Phone", "Time" },
                values: new object[] { 999999, "Auto gestionada", null, "0", "0", "0", "Auto gestionada", "0", "0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Center",
                keyColumn: "Id",
                keyValue: 999999);
        }
    }
}
