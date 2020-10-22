using Microsoft.EntityFrameworkCore.Migrations;

namespace vacunAPP.Migrations
{
    public partial class SeedInstituteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Institute",
                columns: new[] { "Id", "Address", "Lat", "Locale", "Long", "Name", "Phone", "Time" },
                values: new object[,]
                {
                    { 1, "Aranguren 2701 (Pabellón I)", "-34.624292", "Flores", "-58.469422", "Hospital Álvarez", null, "lunes a viernes de 8:00 a 12:00 hs." },
                    { 32, "Directorio 4210", "-34.643236", "Parque Avellaneda", "-58.482134", "CeSac 13", "0800-555-VACUNAPP", "lunes a viernes 8:30 a 13:00 hs y de 14:00 a 15:45 hs" },
                    { 33, "Miralla y Batlle Ordóñez", "-34.673770", "Villa Lugano", "-58.468230", "CeSac 18", "0800-555-VACUNAPP", "lunes a viernes 8:00 a 13:30 hs y 14:00 a 16:00 hs" },
                    { 34, "Curapaligüe 1905", "-34.642953", "Nueva Pompeya", "-58.442266", "CeSac 19", "0800-555-VACUNAPP", "lunes a viernes 8:30 a 12 hs y de 13 a 16 hs" },
                    { 35, "Ana M. Janner y Charrúa", "-34.649379", "Villa Soldati", "-58.438103", "CeSac 20", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 12:30 hs y de 13:30 a 15:30 hs" },
                    { 36, "Pasaje L entre Martínez Castro y Laguna", "-34.657887", "Villa Soldati", "-58.455484", "CeSac 24", "0800-555-VACUNAPP", "lunes a viernes de 9:00 a 12:00 hs y 14:00 a 17:00 hs" },
                    { 37, "Av. Riestra y Ana María Janner", "-34.645813", "Nueva Pompeya", "-58.433683", "CeSac 31", "0800-555-VACUNAPP", "lunes a viernes 8:00 a 15:00 hs." },
                    { 38, "Esteban Bonorino 1729 y Castañares", "-34.645072", "Flores", "-58.445485", "CeSac 40", "0800-555-VACUNAPP", "lunes a viernes de 9:00 a 16:00 hs" },
                    { 39, "Fonrouge 4377", "-34.677722", "Villa Lugano", "-58.466531", "CeSac 43", "0800-555-VACUNAPP", "lunes a viernes 8:30 a 12 hs y 13:15 a 14:30 hs" },
                    { 40, "Saraza 4202", "-34.660569", "Barrio Samoré", "-58.467500", "CeSac 44", "0800-555-VACUNAPP", "lunes, martes, miércoles y viernes de 9 a 13 hs y de 14 a 16 hs. Jueves de 9 a 11 hs y de 14 a 16 hs" },
                    { 41, "Av. Gral. Fernández de la Cruz 4402", "-34.671621", "Villa Lugano", "-58.457167", "Hospital Cecilia Grierson", "0800-555-VACUNAPP", "Lunes a viernes de 9:00 a 12:00 hs. (4604-9000 Interno 5)" },
                    { 42, "Terrada 5850", "-34.576444", "Villa Pueyrredón", "-58.509429", "CeSac 2", "0800-555-VACUNAPP", "Lunes, miércoles y jueves de 8:00 a 12.30 hs, y de 14:00 a 16:00 hs. Martes y viernes de 8:00 a 12.30 hs." },
                    { 43, "Olazábal 3960", "-34.569800", "Villa Urquiza", "-58.474324", "CeSac 12", "0800-555-VACUNAPP", "Lunes a viernes de 08:30 a 13:00 hs, y de 14:00 a 16:30 hs." },
                    { 31, "M. Acosta y Roca", "-34.666766", "Villa Soldati", "-58.440949", "CeSac 6", "0800-555-VACUNAPP", "Lunes a viernes de 8:30 a 13:00 hs y de 14:00 a 15:30 hs" },
                    { 44, "Arias 3783", "-34.547747", "Saavedra", "-58.486640", "CeSac 27", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 13:00 hs y de 14:00 a 16:00 hs" },
                    { 46, "Agüero 940", "-34.599020", "Balvanera", "-58.410594", "CeSac 11", "0800-555-VACUNAPP", "Lunes a viernes de 8:00 a 12:00 hs." },
                    { 47, "Cochabamba 2626", "-34.625335", "Balvanera", "-58.402305", "CeSac 45", "0800-555-VACUNAPP", "lunes a viernes de 9:00 a 12:00 hs" },
                    { 48, "Pilar 950", "-34.649343", "Mataderos", "-58.515823", "Hospital Santojanni", "0800-555-VACUNAPP", "Todos los días, inclusive feriados, de 8:00 a 12:45 hs" },
                    { 49, "Soldado de la Frontera 5144", "-34.684538", "Villa Lugano", "-58.464147", "CeSac 3", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 12:00 hs y de 13:00 a 16:00 hs" },
                    { 50, "Alberdi y Pilar", "-34.655557", "Mataderos", "-58.507240", "CeSac 4", "0800-555-VACUNAPP", "lunes a viernes de 8 a 13 hs y de 14 a 16 hs" },
                    { 51, "Av. Piedrabuena 3140", "-34.670523", "Villa Lugano", "-58.495309", "CeSac 5", "0800-555-VACUNAPP", "lunes a viernes de 8 a 12 hs y de 14 a 15.30 hs" },
                    { 52, "2 de Abril y Montiel", "-34.678111", "Villa Lugano", "-58.491275", "CeSac 7", "0800-555-VACUNAPP", "lunes a viernes de 8 a 13 hs y de 14 a 16 hs" },
                    { 53, "Santander 5955", "-34.673065", "Villa Lugano", "-58.485930", "CeSac 28", "0800-555-VACUNAPP", "lunes a viernes de 8 a 14 hs" },
                    { 54, "Avenida General Paz 15378 Manzana 3 Casa 40", "-34.683740", "Villa Lugano", "-58.488679", "CeSac 29", "0800-555-VACUNAPP", "lunes a viernes de 9 a 11.30 hs y de 11 a 15 hs" },
                    { 55, "Carhue y Av. De los Corrales", "-34.665839", "Mataderos", "-58.504135", "CeSac 37", "0800-555-VACUNAPP", "lunes a viernes de 8 a 12:30 hs y 13:30 a 17 hs" },
                    { 56, "Esteban de Luca 2151", "-34.634832", "Parque Patricios", "-58.402569", "Hospital Sardá", "0800-555-VACUNAPP", "lunes a viernes de 8.30 a 16.30 hs" },
                    { 57, "Av. Córdoba 5741", "-34.586443", "Villa Crespo", "-58.441751", "CeSac 33", "0800-555-VACUNAPP", "Turno mañana: lunes, miércoles y jueves de 8.30 a 12.30 hs; martes y viernes de 10 a 12.30 hs. Turno tarde: lunes a viernes de 14 a 16 hs," },
                    { 45, "Gral. Urquiza 609", "-34.617634", "Balvanera", "-58.409436", "Hospital Ramos Mejía", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 16:00 hs." },
                    { 58, "Mercedes 1371/79", "-34.621943", "Villa Santa Rita", "-58.491833", "CeSac 36", "0800-555-VACUNAPP", "Lunes a viernes de 8:30 hs a 12 hs y de 14 a 16.30 hs." },
                    { 30, "Varela 1301", "-34.644118", "Flores", "-58.453681", "Hospital Piñero", "0800-555-VACUNAPP", "Lunes a viernes de 8:00 a 12:00 hs." },
                    { 28, "Osvaldo Cruz y Zabaleta", "-34.656475", "Barracas", "-58.399222", "CeSac 35", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 16.30 hs" },
                    { 2, "Gral. José G. Artigas 2262", "-34.606526", "Villa del Parque", "-58.478186", "CeSac 34", "0800-555-VACUNAPP", "lunes a viernes de 13:00 a 17:00 hs. Solicitar turno al 2821-3634" },
                    { 3, "Almirante Brown 240", "-34.628423", "La Boca", "-58.366048", "Hospital Argerich", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 12:00 hs" },
                    { 4, "Irala 1254", "-34.640111", "La Boca", "-58.366091", "CeSac 9", "0800-555-VACUNAPP", "lunes, martes, miércoles y viernes de 8:00 a 12:00 hs y de 14:00 a 17:00 hs" },
                    { 5, "Humberto 1º 470", "-34.620725", "San Telmo", "-58.372486", "CeSac 15", "0800-555-VACUNAPP", "lunes a viernes de 8.00 a 12.00 hs y de 14:00 a 17:00 hs" },
                    { 6, "Ministro Brin 843", "-34.631301", "La Boca", "-58.357852", "CeSac 41", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 13:00 hs y de 14:00 a 17:30 hs" },
                    { 7, "Regimiento Patricios 1941", "-34.648849", "La Boca", "-58.368022", "Centro Boca - Barracas", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 14:00 hs" },
                    { 8, "Av. Córdoba 2351", "-34.599444", "Recoleta", "-58.400681", "Hospital de Clínicas", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 14:00 hs" },
                    { 9, "Díaz Vélez 5044 Pabellón Romano", "-34.608875", "Caballito", "-58.437889", "Hospital Durand", "0800-555-VACUNAPP", "lunes a viernes de 8 a 15 hs. Sabados y domingos de 8 a 12 hs. y 13 a 17 hs." },
                    { 10, "Fragata Pres. Sarmiento 2152", "-34.600874", "Paternal", "-58.459089", "CeSac 22", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 18:30 hs" },
                    { 11, "Medrano 350", "-34.606614", "Almagro", "-58.421452", "CeSac 38", "0800-555-VACUNAPP", "lunes a viernes 9:00 a 12:00 hs y de 14:00 a 16:00 hs" },
                    { 12, "Montes de Oca 40", "-34.628900", "Barracas", "-58.377635", "Hospital Elizalde", "0800-555-VACUNAPP", "Lunes a viernes de 8 a 15 hs" },
                    { 13, "Cerviño 3356", "-34.581139", "Palermo", "-58.406896", "Hospital Fernández", "0800-555-VACUNAPP", "Lunes a viernes de 8 a 16 hs" },
                    { 29, "24 de November 1679", "-34.631019", "Parque Patricios", "-58.409865", "CeSac 39", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 16:30 hs" },
                    { 14, "El Salvador 4087 Escuela N°9", "-34.592726", "Palermo", "-58.420525", "CeSac 17", "0800-555-VACUNAPP", "lunes a viernes de 9:00 a 16:00 hs" },
                    { 16, "E.E.U.U. de Brasil y Antártida Argentina Escuela 25", null, "Palermo", null, "CeSac 25", "0800-555-VACUNAPP", "lunes a viernes de 9:00 a 15.00 hs" },
                    { 17, "Gurruchaga 1939", "-34.587150", "Villa Crespo", "-58.425744", "CeSac 26", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 14:00 hs. Solicitando turno al 4897-2156" },
                    { 18, "Calle playón (ex galpón SIC)", "-34.583691", "Barrio 31 (Retiro)", "-58.378639", "CeSac 47", "0800-555-VACUNAPP", "lunes a viernes 9:00 a 15:00 hs" },
                    { 19, "Combate de Los Pozos 1881", "-34.630832", "Constitución", "-58.391527", "Hospital Garrahan", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 15:00 hs" },
                    { 20, "Sanchez De Bustamante 1330", "-34.594851", "Palermo", "-58.412740", "Hospital Gutiérrez", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 14:30 hs" },
                    { 21, "Uspallata 2272", "-34.637233", "Parque Patricios", "-58.393042", "Hospital Muñiz", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 15:00 hs." },
                    { 22, "Vélez Sarsfield 1271", "-34.649026", "Barracas", "-58.389308", "CeSac 1", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 16:30 hs" },
                    { 23, "Osvaldo Cruz 3485", "-34.655839", "Barracas", "-58.395274", "CeSac 8", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 16:30 hs" },
                    { 24, "Amancio Alcorta 1402", "-34.633349", "Barracas", "-58.383729", "CeSac 10", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 16:30 hs" },
                    { 25, "Osvaldo Cruz 2045", "-34.651815", "Barracas", "-58.374546", "CeSac 16", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 16:30 hs" },
                    { 26, "Amancio Alcorta 2900", "-34.645742", "Parque Patricios", "-58.401625", "CeSac 30", "0800-555-VACUNAPP", "lunes a viernes de 9:00 a 13:00 hs" },
                    { 27, "Charrúa 2900", "-34.654251", "Nueva Pompeya", "-58.431151", "CeSac 32", "0800-555-VACUNAPP", "lunes a viernes de 08:30 a 16:30 hs" },
                    { 15, "Gendarmería Nacional 522", "-34.584676", "Retiro", "-58.373258", "CeSac 21", "0800-555-VACUNAPP", "lunes a viernes de 8:30 a 12:30 hs" },
                    { 59, "Nueva York 3952", "-34.599903", "Villa Devoto", "-58.511231", "Hospital Zubizarreta", "0800-555-VACUNAPP", "lunes a viernes de 8:00 a 14:00 hs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Institute",
                keyColumn: "Id",
                keyValue: 59);
        }
    }
}
