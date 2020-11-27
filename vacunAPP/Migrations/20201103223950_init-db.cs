using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {           

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                    table.UniqueConstraint("AlternateKey_NIF", x => x.NIF);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Inyection = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Month = table.Column<short>(type: "smallint", nullable: false),
                    ApplicationType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ExtraInfo = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    NIF = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Gender = table.Column<string>(type: "char(1)", nullable: false),
                    BornDate = table.Column<DateTime>(nullable: false),
                    ParentPersonNIF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.NIF);
                    table.ForeignKey(
                        name: "FK_Person_Users_NIF",
                        column: x => x.NIF,
                        principalTable: "Users",
                        principalColumn: "NIF",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_Person_ParentPersonNIF",
                        column: x => x.ParentPersonNIF,
                        principalTable: "Person",
                        principalColumn: "NIF",
                        onDelete: ReferentialAction.Restrict);
                });            

            migrationBuilder.CreateIndex(
                name: "IX_Person_ParentPersonNIF",
                table: "Person",
                column: "ParentPersonNIF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Institute");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
