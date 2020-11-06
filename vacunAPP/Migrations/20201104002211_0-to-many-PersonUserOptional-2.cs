using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class _0tomanyPersonUserOptional2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Users_UserEmail",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_UserEmail",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Person_NIF",
                table: "Users",
                column: "NIF",
                principalTable: "Person",
                principalColumn: "NIF",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Person_NIF",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Person",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserEmail",
                table: "Person",
                column: "UserEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Users_UserEmail",
                table: "Person",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
