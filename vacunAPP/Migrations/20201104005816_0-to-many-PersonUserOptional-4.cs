using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class _0tomanyPersonUserOptional4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Users_NIF",
                table: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Person_NIF",
                table: "Users",
                column: "NIF",
                principalTable: "Person",
                principalColumn: "NIF",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Person_NIF",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Users_NIF",
                table: "Person",
                column: "NIF",
                principalTable: "Users",
                principalColumn: "NIF",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
