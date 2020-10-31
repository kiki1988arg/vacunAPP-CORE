using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class addMoreColumnsToVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AplicationType",
                table: "Vaccine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Vaccine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraInfo",
                table: "Vaccine",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Inyection",
                table: "Vaccine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "Vaccine",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AplicationType",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "ExtraInfo",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "Inyection",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "Vaccine");
        }
    }
}
