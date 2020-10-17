using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddAnotherEmailKeyToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_NIF_Email",
                table: "Users");

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_Email",
                table: "Users",
                column: "Email");

            migrationBuilder.AddUniqueConstraint(
                name: "AlternateKey_NIF",
                table: "Users",
                column: "NIF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_Email",
                table: "Users");

            migrationBuilder.DropUniqueConstraint(
                name: "AlternateKey_NIF",
                table: "Users");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_NIF_Email",
                table: "Users",
                columns: new[] { "NIF", "Email" });
        }
    }
}
