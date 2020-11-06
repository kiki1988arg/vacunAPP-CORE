using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class TypeColumnNotebook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "Notebook",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "Notebook",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);
        }
    }
}
