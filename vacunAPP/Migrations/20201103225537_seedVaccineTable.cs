using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class seedVaccineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vaccine",
                columns: new[] { "Id", "ApplicationType", "Description", "ExtraInfo", "Inyection", "Month", "Name" },
                values: new object[,]
                {
                    { 1, "Forma de aplicación: Intradérmica.", "Previene las formas invasivas de tuberculosis. Debe aplicarse antes de egresar de la maternidad.", "", "(única dosis)", (short)0, "BCG" },
                    { 25, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus de la influenza.", "", "(si es la primera vez son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)", (short)18, "Gripe" },
                    { 26, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus de la influenza.", "", "(si es la primera vez son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)", (short)24, "Gripe" },
                    { 27, "Forma de aplicación: Intramuscular.", "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).", "", "(1° refuerzo)", (short)72, "Polio IPV" },
                    { 28, "Forma de aplicación: Subcutánea.", "Previene sarampión, rubeola y paperas.", "", "(2° dosis)", (short)72, "Triple Viral" },
                    { 29, "Forma de aplicación: Intramuscular.", "Previene difteria, tétanos y tos convulsa.", "", "(2° refuerzo)", (short)72, "Triple Bacteriana Celular DTP" },
                    { 30, "Forma de aplicación: Intramuscular.", "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.", "", "(única dosis)", (short)132, "Meningococo Conjugada Cuadrivalente" },
                    { 31, "Forma de aplicación: Intramuscular.", "Previene difteria, tétanos y tos convulsa.", "", "(refuerzo)", (short)132, "Triple Bacteriana Acelular dpaT" },
                    { 32, "Forma de aplicación: Intramuscular.", "Previene la infección por el Virus del Papiloma Humano (genotipos 6 y 11 de bajo riesgo y 16 y 18 de alto riesgo), principal causa de cáncer de cuello de útero, otros cánceres relacionados y verrugas genitales.", "", "(2° dosis)", (short)132, "VPH (2 dosis)" },
                    { 33, "Forma de aplicación: Subcutánea.", "Previene fiebre amarilla, enfermedad causada por un virus que se transmite a través de la picadura de mosquitos. Las zonas de riesgo en Argentina son Misiones, Formosa, norte de Corrientes, y algunos departamentos de Chaco, Salta y Jujuy.", "EXCLUSIVO ZONAS DE RIESGO", "(refuerzo)", (short)132, "Fiebre amarilla" },
                    { 34, "Forma de aplicación: Intramuscular.", "Previene hepatitis B.", "", "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)", (short)132, "Hepatitis B" },
                    { 35, "Forma de aplicación: Subcutánea.", "Previene sarampión, rubeola y paperas.", "", "(en caso de no haber recibido el esquema de vacunación completo -dos dosis después del año- se recomienda iniciarlo o completarlo)", (short)132, "Triple Viral" },
                    { 36, "Forma de aplicación: Intramuscular.", "Previene hepatitis B.", "", "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)", (short)180, "Hepatitis B" },
                    { 37, "Forma de aplicación: Subcutánea.", "Previene sarampión, rubeola y paperas.", "", "(en caso de no haber recibido el esquema de vacunación -dos dosis después del año- se recomienda iniciarlo o completarlo)", (short)180, "Doble Viral SR o Triple Viral SRP" },
                    { 38, "Forma de aplicación: Intramuscular.", "Previene fiebre hemorrágica argentina, que es una enfermedad infecciosa endémica en el noroeste de la provincia de Buenos Aires, sur de Córdoba, sur de Santa fe y norte de La Pampa.", "EXCLUSIVO ZONAS DE RIESGO", "(única dosis)", (short)180, "Fiebre hemorrágica argentina" },
                    { 39, "Forma de aplicación: Intramuscular.", "Previene hepatitis B.", "", "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)", (short)216, "Hepatitis B" },
                    { 40, "Forma de aplicación: Subcutánea.", "Previene sarampión, rubeola y paperas.", "", "(en caso de no haber recibido el esquema de vacunación se recomienda iniciarlo o completarlo. Las personas que nacieron antes de 1965 se consideran inmunes. Las que nacieron después de 1965 tienen que vacunarse solo si no tienen las dos dosis de la infancia o si tienen serología negativa)", (short)216, "Triple Viral" },
                    { 41, "Forma de aplicación: Inyectable.", "Previene difteria y tétanos.", "", "(refuerzo cada 10 años)", (short)216, "Doble Bacteriana o Doble Adulto" },
                    { 42, "Forma de aplicación: Intramuscular.", "Previene fiebre hemorrágica argentina, que es una enfermedad infecciosa endémica en el noroeste de la provincia de Buenos Aires, sur de Córdoba, sur de Santa fe y norte de La Pampa.", "EXCLUSIVO ZONAS DE RIESGO", "(única dosis)", (short)216, "Fiebre hemorrágica argentina" },
                    { 43, "Forma de aplicación: Intramuscular.", "Previene hepatitis B.", "", "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)", (short)780, "Hepatitis B" },
                    { 24, "Forma de aplicación: Subcutánea.", "Previene fiebre amarilla, enfermedad causada por un virus que se transmite a través de la picadura de mosquitos. Las zonas de riesgo en Argentina son Misiones, Formosa, norte de Corrientes, y algunos departamentos de Chaco, Salta y Jujuy.", "EXCLUSIVO ZONAS DE RIESGO", "(1° dosis)", (short)18, "Fiebre amarilla" },
                    { 44, "Forma de aplicación: Inyectable.", "Previene difteria y tétanos.", "", "(refuerzo cada 10 años)", (short)780, "Doble Bacteriana o Doble Adulto" },
                    { 23, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus de la influenza.", "", "(si es la primera vez son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)", (short)192, "Gripe" },
                    { 21, "Forma de aplicación: Subcutánea, Intramuscular.", "Previene varicela y sus complicaciones.", "", "(única dosis)", (short)15, "Varicela" },
                    { 2, "Forma de aplicación: Intramuscular.", "Previene la transmisión vertical (de la madre al bebé) de la hepatitis B. Debe aplicarse en las primeras 12 horas de vida.", "", "(dosis neonatal)", (short)0, "Hepatitis B" },
                    { 3, "Forma de aplicación: Intramuscular", "Previene meningitis, neumonía y sepsis causada por los 13 serotipos de neumococo contenidos en la vacuna.", "", "(1° dosis)", (short)2, "Neumococo Conjugada" },
                    { 4, "Forma de aplicación: Intramuscular.", "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.", "", "(1° dosis)", (short)2, "Quíntuple o Pentavalente Celular" },
                    { 5, "Forma de aplicación: Intramuscular.", "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).", "", "(1° dosis)", (short)2, "Polio IPV" },
                    { 6, "Forma de aplicación: Vía oral.", "Previene la diarrea por rotavirus.", "", "(1° dosis)", (short)2, "Rotavirus" },
                    { 7, "Forma de aplicación: Intramuscular.", "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.", "", "(1° dosis)", (short)3, "Meningococo Conjugada Cuadrivalente" },
                    { 8, "Forma de aplicación: Intramuscular.", "Previene meningitis, neumonía y sepsis causada por los 13 serotipos de neumococo contenidos en la vacuna.", "", "(2° dosis)", (short)4, "Neumococo conjugada" },
                    { 9, "Forma de aplicación: Intramuscular.", "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.", "", "(2° dosis)", (short)4, "Quíntuple o Pentavalente" },
                    { 10, "Forma de aplicación: Intramuscular.", "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).", "", "(2° dosis)", (short)4, "Polio IPV" },
                    { 11, "Forma de aplicación: Vía oral.", "Previene la diarrea por rotavirus.", "", "(2° dosis)", (short)4, "Rotavirus" },
                    { 12, "Forma de aplicación: Intramuscular.", "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.", "", "(2° dosis)", (short)5, "Meningococo Conjugada Cuadrivalente" },
                    { 13, "Forma de aplicación: Intramuscular.", "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.", "", "(3° dosis)", (short)6, "Quíntuple o Pentavalente" },
                    { 14, "Forma de aplicación: Intramuscular.", "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).", "", "(3° dosis)", (short)6, "Polio IPV" },
                    { 15, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus de la influenza.", "", "(si es la primera aplicación son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)", (short)6, "Gripe" },
                    { 16, "Forma de aplicación: Inyectable.", "Previene meningitis, neumonía y sepsis causada por los 13 serotipos de neumococo contenidos en la vacuna.", "", "(refuerzo)", (short)12, "Neumococo Conjugada" },
                    { 17, "Forma de aplicación: Intramuscular.", "Previene hepatitis A y sus complicaciones.", "", "(única dosis)", (short)12, "Hepatitis A" },
                    { 18, "Forma de aplicación: Subcutánea.", "Previene sarampión, rubeola y paperas.", "", "(1° dosis)", (short)12, "Triple Viral" },
                    { 19, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus de la influenza.", "", "(si es la primera aplicación son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)", (short)12, "Gripe" },
                    { 20, "Forma de aplicación: Intramuscular.", "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.", "", "(refuerzo)", (short)15, "Meningococo Conjugada Cuadrivalente" },
                    { 22, "Forma de aplicación: Intramuscular.", "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.", "", "(1° refuerzo)", (short)192, "Cuádruple o Quíntuple Pentavalente Celular" },
                    { 45, "Forma de aplicación: Intramuscular.", "Previene las complicaciones y muerte causadas por el virus de la influenza.", "", "(dosis anual)", (short)780, "Gripe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Vaccine",
                keyColumn: "Id",
                keyValue: 45);
        }
    }
}
