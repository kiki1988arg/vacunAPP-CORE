using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class InyectionToStringTableVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AplicationType",
                table: "Vaccine",
                newName: "ApplicationType");

            migrationBuilder.AlterColumn<string>(
                name: "Inyection",
                table: "Vaccine",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationType",
                table: "Vaccine",
                newName: "AplicationType");

            migrationBuilder.AlterColumn<string>(
                name: "Inyection",
                table: "Vaccine",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);
        }
    }
}
