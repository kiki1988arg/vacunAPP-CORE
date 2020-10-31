using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class columnsTypeVaccineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vaccine",
                type: "nvarchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Month",
                table: "Vaccine",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "Inyection",
                table: "Vaccine",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ExtraInfo",
                table: "Vaccine",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vaccine",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AplicationType",
                table: "Vaccine",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");

            migrationBuilder.AlterColumn<int>(
                name: "Month",
                table: "Vaccine",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Inyection",
                table: "Vaccine",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "ExtraInfo",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "AplicationType",
                table: "Vaccine",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.InsertData(
                table: "Vaccine",
                columns: new[] { "Id", "AplicationType", "Description", "ExtraInfo", "Inyection", "Month", "Name" },
                values: new object[,]
                {
                    { 1, null, null, null, 0, 0, "BCG" },
                    { 15, null, null, null, 0, 0, "la vacuna contra la Fiebre Amarilla" },
                    { 14, null, null, null, 0, 0, "la Doble Vital" },
                    { 13, null, null, null, 0, 0, "VPH contra el Virus Papiloma Humano" },
                    { 12, null, null, null, 0, 0, "Doble Bacterinana," },
                    { 11, null, null, null, 0, 0, "Triple Bacteriana Acelular" },
                    { 10, null, null, null, 0, 0, "la Triple Bacteriano Celular," },
                    { 16, null, null, null, 0, 0, "la vacuna contra la Fiebre hemorrágica argentina." },
                    { 9, null, null, null, 0, 0, "Hepatitis A, Varicela" },
                    { 7, null, null, null, 0, 0, "Rubeóla, Paperas" },
                    { 6, null, null, null, 0, 0, "la Triple vital contra el Sarampión," },
                    { 5, null, null, null, 0, 0, "la Sabin bivalente oral Meningococo" },
                    { 4, null, null, null, 0, 0, "la Quíntuple Prevalente DTP-HB-Hib:" },
                    { 3, null, null, null, 0, 0, "contra el Neumococo" },
                    { 2, null, null, null, 0, 0, "Hepatitis B" },
                    { 8, null, null, null, 0, 0, "la vacuna contra la gripe" },
                    { 17, null, null, null, 0, 0, "Covid-19" }
                });
        }
    }
}
