using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddNotebookTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Center_CenterId1",
                table: "Notebook");

            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId1",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_CenterId1",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_VaccineId1",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "CenterId1",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "ProfesionalId",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "VaccineId1",
                table: "Notebook");

            migrationBuilder.AlterColumn<int>(
                name: "VaccineId",
                table: "Notebook",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CenterId",
                table: "Notebook",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_CenterId",
                table: "Notebook",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_VaccineId",
                table: "Notebook",
                column: "VaccineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Center_CenterId",
                table: "Notebook",
                column: "CenterId",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId",
                table: "Notebook",
                column: "VaccineId",
                principalTable: "Vaccine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Center_CenterId",
                table: "Notebook");

            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_CenterId",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_VaccineId",
                table: "Notebook");

            migrationBuilder.AlterColumn<string>(
                name: "VaccineId",
                table: "Notebook",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CenterId",
                table: "Notebook",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CenterId1",
                table: "Notebook",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfesionalId",
                table: "Notebook",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaccineId1",
                table: "Notebook",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_CenterId1",
                table: "Notebook",
                column: "CenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_VaccineId1",
                table: "Notebook",
                column: "VaccineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Center_CenterId1",
                table: "Notebook",
                column: "CenterId1",
                principalTable: "Center",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Vaccine_VaccineId1",
                table: "Notebook",
                column: "VaccineId1",
                principalTable: "Vaccine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
