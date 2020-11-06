using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class _0tomanyPersonUserOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Person",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
