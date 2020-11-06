using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddProfesionalInstituteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstituteId",
                table: "Center",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Institute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CUIT = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    License = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Contract = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MN = table.Column<string>(nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Function = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    InstituteId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesional_Institute_InstituteId",
                        column: x => x.InstituteId,
                        principalTable: "Institute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Center_InstituteId",
                table: "Center",
                column: "InstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesional_InstituteId",
                table: "Profesional",
                column: "InstituteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Center_Institute_InstituteId",
                table: "Center",
                column: "InstituteId",
                principalTable: "Institute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Center_Institute_InstituteId",
                table: "Center");

            migrationBuilder.DropTable(
                name: "Profesional");

            migrationBuilder.DropTable(
                name: "Institute");

            migrationBuilder.DropIndex(
                name: "IX_Center_InstituteId",
                table: "Center");

            migrationBuilder.DropColumn(
                name: "InstituteId",
                table: "Center");
        }
    }
}
