using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddPropertyToNotebook2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId",
                table: "Notebook");

            migrationBuilder.AlterColumn<int>(
                name: "VaccineId",
                table: "Notebook",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId",
                table: "Notebook",
                column: "VaccineId",
                principalTable: "Vaccine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId",
                table: "Notebook");

            migrationBuilder.AlterColumn<int>(
                name: "VaccineId",
                table: "Notebook",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId",
                table: "Notebook",
                column: "VaccineId",
                principalTable: "Vaccine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
