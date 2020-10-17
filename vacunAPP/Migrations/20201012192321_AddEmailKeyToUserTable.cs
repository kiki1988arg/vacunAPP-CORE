using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddEmailKeyToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_NIF",
                table: "Users");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_NIF_Email",
                table: "Users",
                columns: new[] { "NIF", "Email" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_NIF_Email",
                table: "Users");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_NIF",
                table: "Users",
                column: "NIF");
        }
    }
}
