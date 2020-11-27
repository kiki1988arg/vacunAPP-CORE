using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddPropertyToNotebook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Center_CenterId",
                table: "Notebook");

            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Profesional_ProfessionalId",
                table: "Notebook");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalId",
                table: "Notebook",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CenterId",
                table: "Notebook",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Center_CenterId",
                table: "Notebook",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Profesional_ProfessionalId",
                table: "Notebook",
                column: "ProfessionalId",
                principalTable: "Profesional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Center_CenterId",
                table: "Notebook");

            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Profesional_ProfessionalId",
                table: "Notebook");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessionalId",
                table: "Notebook",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CenterId",
                table: "Notebook",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Center_CenterId",
                table: "Notebook",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Profesional_ProfessionalId",
                table: "Notebook",
                column: "ProfessionalId",
                principalTable: "Profesional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
