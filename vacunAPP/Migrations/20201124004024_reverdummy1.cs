using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class reverdummy1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Center",
                columns: new[] { "Id", "Address", "InstituteId", "Lat", "Locale", "Long", "Name", "Phone", "Time" },
                values: new object[] { 999999, "Auto gestionada", null, "0", "0", "0", "Auto gestionada", "0", "0" });

            migrationBuilder.InsertData(
                table: "Institute",
                columns: new[] { "Id", "CUIT", "Contract", "CreatedAt", "License", "Name" },
                values: new object[] { 999999, "-", "-", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "-", "-" });

            migrationBuilder.InsertData(
                table: "Profesional",
                columns: new[] { "Id", "Email", "Function", "InstituteId", "LastName", "MN", "NIF", "Name", "Password" },
                values: new object[] { 999999, "-", "-", 999999, "-", "999999", "-", "-", "-" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Center",
                keyColumn: "Id",
                keyValue: 999999);

            migrationBuilder.DeleteData(
                table: "Profesional",
                keyColumn: "Id",
                keyValue: 999999);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 999999);
        }
    }
}
