using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class AddNotebookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notebook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationDate = table.Column<DateTime>(nullable: false),
                    NIF = table.Column<string>(nullable: true),
                    VaccineId = table.Column<string>(nullable: true),
                    VaccineId1 = table.Column<int>(nullable: true),
                    CenterId = table.Column<string>(nullable: true),
                    CenterId1 = table.Column<int>(nullable: true),
                    ProfesionalId = table.Column<string>(nullable: true),
                    ProfessionalId = table.Column<int>(nullable: true),
                    PersonNIF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notebook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notebook_Center_CenterId1",
                        column: x => x.CenterId1,
                        principalTable: "Center",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notebook_Person_PersonNIF",
                        column: x => x.PersonNIF,
                        principalTable: "Person",
                        principalColumn: "NIF",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notebook_Profesional_ProfessionalId",
                        column: x => x.ProfessionalId,
                        principalTable: "Profesional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notebook_Vaccine_VaccineId1",
                        column: x => x.VaccineId1,
                        principalTable: "Vaccine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_CenterId1",
                table: "Notebook",
                column: "CenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_PersonNIF",
                table: "Notebook",
                column: "PersonNIF");

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_ProfessionalId",
                table: "Notebook",
                column: "ProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_VaccineId1",
                table: "Notebook",
                column: "VaccineId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notebook");
        }
    }
}
