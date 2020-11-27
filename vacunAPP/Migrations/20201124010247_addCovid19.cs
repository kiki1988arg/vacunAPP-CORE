using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class addCovid19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vaccine",
                columns: new[] { "Id", "ApplicationType", "Description", "ExtraInfo", "Inyection", "Month", "Name" },
                values: new object[] { 46, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus Covid-19.", "", "(dosis anual)", (short)0, "Covid-19" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 46);
        }
    }
}
