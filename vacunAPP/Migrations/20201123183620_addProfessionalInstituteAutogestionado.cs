using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class addProfessionalInstituteAutogestionado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Institute",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

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
                table: "Profesional",
                keyColumn: "Id",
                keyValue: 999999);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 999999);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Institute",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");
        }
    }
}
