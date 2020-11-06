using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class NotebookPersonRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Person_PersonNIF",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_PersonNIF",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "PersonNIF",
                table: "Notebook");

            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "Notebook",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_NIF",
                table: "Notebook",
                column: "NIF");

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Person_NIF",
                table: "Notebook",
                column: "NIF",
                principalTable: "Person",
                principalColumn: "NIF",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Person_NIF",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_NIF",
                table: "Notebook");

            migrationBuilder.AlterColumn<string>(
                name: "NIF",
                table: "Notebook",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonNIF",
                table: "Notebook",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_PersonNIF",
                table: "Notebook",
                column: "PersonNIF");

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Person_PersonNIF",
                table: "Notebook",
                column: "PersonNIF",
                principalTable: "Person",
                principalColumn: "NIF",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
