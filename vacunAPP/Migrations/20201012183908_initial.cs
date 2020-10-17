using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NIF = table.Column<string>(nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    password = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    BornDate = table.Column<DateTime>(nullable: false),
                    IsVerify = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vaccine",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BCG" },
                    { 15, "la vacuna contra la Fiebre Amarilla" },
                    { 14, "la Doble Vital" },
                    { 13, "VPH contra el Virus Papiloma Humano" },
                    { 12, "Doble Bacterinana," },
                    { 11, "Triple Bacteriana Acelular" },
                    { 10, "la Triple Bacteriano Celular," },
                    { 16, "la vacuna contra la Fiebre hemorrágica argentina." },
                    { 9, "Hepatitis A, Varicela" },
                    { 7, "Rubeóla, Paperas" },
                    { 6, "la Triple vital contra el Sarampión," },
                    { 5, "la Sabin bivalente oral Meningococo" },
                    { 4, "la Quíntuple Prevalente DTP-HB-Hib:" },
                    { 3, "contra el Neumococo" },
                    { 2, "Hepatitis B" },
                    { 8, "la vacuna contra la gripe" },
                    { 17, "Covid-19" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vaccine");
        }
    }
}
