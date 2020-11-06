using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class _0tomanyPersonUserOptional3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Person_NIF",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Users_Person_NIF",
                table: "Users",
                column: "NIF",
                principalTable: "Person",
                principalColumn: "NIF",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
