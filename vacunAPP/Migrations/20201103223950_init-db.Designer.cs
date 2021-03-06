﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vacunAPP.Data;

namespace vacunAPP.Migrations
{
    [DbContext(typeof(vacunAPPContext))]
    [Migration("20201103223950_init-db")]
    partial class initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vacunAPP.Core.Domain.Institute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Lat")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Long")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Institute");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Aranguren 2701 (Pabellón I)",
                            Lat = "-34.624292",
                            Locale = "Flores",
                            Long = "-58.469422",
                            Name = "Hospital Álvarez",
                            Time = "lunes a viernes de 8:00 a 12:00 hs."
                        },
                        new
                        {
                            Id = 2,
                            Address = "Gral. José G. Artigas 2262",
                            Lat = "-34.606526",
                            Locale = "Villa del Parque",
                            Long = "-58.478186",
                            Name = "CeSac 34",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 13:00 a 17:00 hs. Solicitar turno al 2821-3634"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Almirante Brown 240",
                            Lat = "-34.628423",
                            Locale = "La Boca",
                            Long = "-58.366048",
                            Name = "Hospital Argerich",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 12:00 hs"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Irala 1254",
                            Lat = "-34.640111",
                            Locale = "La Boca",
                            Long = "-58.366091",
                            Name = "CeSac 9",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes, martes, miércoles y viernes de 8:00 a 12:00 hs y de 14:00 a 17:00 hs"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Humberto 1º 470",
                            Lat = "-34.620725",
                            Locale = "San Telmo",
                            Long = "-58.372486",
                            Name = "CeSac 15",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8.00 a 12.00 hs y de 14:00 a 17:00 hs"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Ministro Brin 843",
                            Lat = "-34.631301",
                            Locale = "La Boca",
                            Long = "-58.357852",
                            Name = "CeSac 41",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 13:00 hs y de 14:00 a 17:30 hs"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Regimiento Patricios 1941",
                            Lat = "-34.648849",
                            Locale = "La Boca",
                            Long = "-58.368022",
                            Name = "Centro Boca - Barracas",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 14:00 hs"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Av. Córdoba 2351",
                            Lat = "-34.599444",
                            Locale = "Recoleta",
                            Long = "-58.400681",
                            Name = "Hospital de Clínicas",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 14:00 hs"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Díaz Vélez 5044 Pabellón Romano",
                            Lat = "-34.608875",
                            Locale = "Caballito",
                            Long = "-58.437889",
                            Name = "Hospital Durand",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8 a 15 hs. Sabados y domingos de 8 a 12 hs. y 13 a 17 hs."
                        },
                        new
                        {
                            Id = 10,
                            Address = "Fragata Pres. Sarmiento 2152",
                            Lat = "-34.600874",
                            Locale = "Paternal",
                            Long = "-58.459089",
                            Name = "CeSac 22",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 18:30 hs"
                        },
                        new
                        {
                            Id = 11,
                            Address = "Medrano 350",
                            Lat = "-34.606614",
                            Locale = "Almagro",
                            Long = "-58.421452",
                            Name = "CeSac 38",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 9:00 a 12:00 hs y de 14:00 a 16:00 hs"
                        },
                        new
                        {
                            Id = 12,
                            Address = "Montes de Oca 40",
                            Lat = "-34.628900",
                            Locale = "Barracas",
                            Long = "-58.377635",
                            Name = "Hospital Elizalde",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 8 a 15 hs"
                        },
                        new
                        {
                            Id = 13,
                            Address = "Cerviño 3356",
                            Lat = "-34.581139",
                            Locale = "Palermo",
                            Long = "-58.406896",
                            Name = "Hospital Fernández",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 8 a 16 hs"
                        },
                        new
                        {
                            Id = 14,
                            Address = "El Salvador 4087 Escuela N°9",
                            Lat = "-34.592726",
                            Locale = "Palermo",
                            Long = "-58.420525",
                            Name = "CeSac 17",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9:00 a 16:00 hs"
                        },
                        new
                        {
                            Id = 15,
                            Address = "Gendarmería Nacional 522",
                            Lat = "-34.584676",
                            Locale = "Retiro",
                            Long = "-58.373258",
                            Name = "CeSac 21",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 12:30 hs"
                        },
                        new
                        {
                            Id = 16,
                            Address = "E.E.U.U. de Brasil y Antártida Argentina Escuela 25",
                            Locale = "Palermo",
                            Name = "CeSac 25",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9:00 a 15.00 hs"
                        },
                        new
                        {
                            Id = 17,
                            Address = "Gurruchaga 1939",
                            Lat = "-34.587150",
                            Locale = "Villa Crespo",
                            Long = "-58.425744",
                            Name = "CeSac 26",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 14:00 hs. Solicitando turno al 4897-2156"
                        },
                        new
                        {
                            Id = 18,
                            Address = "Calle playón (ex galpón SIC)",
                            Lat = "-34.583691",
                            Locale = "Barrio 31 (Retiro)",
                            Long = "-58.378639",
                            Name = "CeSac 47",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 9:00 a 15:00 hs"
                        },
                        new
                        {
                            Id = 19,
                            Address = "Combate de Los Pozos 1881",
                            Lat = "-34.630832",
                            Locale = "Constitución",
                            Long = "-58.391527",
                            Name = "Hospital Garrahan",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 15:00 hs"
                        },
                        new
                        {
                            Id = 20,
                            Address = "Sanchez De Bustamante 1330",
                            Lat = "-34.594851",
                            Locale = "Palermo",
                            Long = "-58.412740",
                            Name = "Hospital Gutiérrez",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 14:30 hs"
                        },
                        new
                        {
                            Id = 21,
                            Address = "Uspallata 2272",
                            Lat = "-34.637233",
                            Locale = "Parque Patricios",
                            Long = "-58.393042",
                            Name = "Hospital Muñiz",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 15:00 hs."
                        },
                        new
                        {
                            Id = 22,
                            Address = "Vélez Sarsfield 1271",
                            Lat = "-34.649026",
                            Locale = "Barracas",
                            Long = "-58.389308",
                            Name = "CeSac 1",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 16:30 hs"
                        },
                        new
                        {
                            Id = 23,
                            Address = "Osvaldo Cruz 3485",
                            Lat = "-34.655839",
                            Locale = "Barracas",
                            Long = "-58.395274",
                            Name = "CeSac 8",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 16:30 hs"
                        },
                        new
                        {
                            Id = 24,
                            Address = "Amancio Alcorta 1402",
                            Lat = "-34.633349",
                            Locale = "Barracas",
                            Long = "-58.383729",
                            Name = "CeSac 10",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 16:30 hs"
                        },
                        new
                        {
                            Id = 25,
                            Address = "Osvaldo Cruz 2045",
                            Lat = "-34.651815",
                            Locale = "Barracas",
                            Long = "-58.374546",
                            Name = "CeSac 16",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 16:30 hs"
                        },
                        new
                        {
                            Id = 26,
                            Address = "Amancio Alcorta 2900",
                            Lat = "-34.645742",
                            Locale = "Parque Patricios",
                            Long = "-58.401625",
                            Name = "CeSac 30",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9:00 a 13:00 hs"
                        },
                        new
                        {
                            Id = 27,
                            Address = "Charrúa 2900",
                            Lat = "-34.654251",
                            Locale = "Nueva Pompeya",
                            Long = "-58.431151",
                            Name = "CeSac 32",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 08:30 a 16:30 hs"
                        },
                        new
                        {
                            Id = 28,
                            Address = "Osvaldo Cruz y Zabaleta",
                            Lat = "-34.656475",
                            Locale = "Barracas",
                            Long = "-58.399222",
                            Name = "CeSac 35",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 16.30 hs"
                        },
                        new
                        {
                            Id = 29,
                            Address = "24 de November 1679",
                            Lat = "-34.631019",
                            Locale = "Parque Patricios",
                            Long = "-58.409865",
                            Name = "CeSac 39",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 16:30 hs"
                        },
                        new
                        {
                            Id = 30,
                            Address = "Varela 1301",
                            Lat = "-34.644118",
                            Locale = "Flores",
                            Long = "-58.453681",
                            Name = "Hospital Piñero",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 8:00 a 12:00 hs."
                        },
                        new
                        {
                            Id = 31,
                            Address = "M. Acosta y Roca",
                            Lat = "-34.666766",
                            Locale = "Villa Soldati",
                            Long = "-58.440949",
                            Name = "CeSac 6",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 8:30 a 13:00 hs y de 14:00 a 15:30 hs"
                        },
                        new
                        {
                            Id = 32,
                            Address = "Directorio 4210",
                            Lat = "-34.643236",
                            Locale = "Parque Avellaneda",
                            Long = "-58.482134",
                            Name = "CeSac 13",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 8:30 a 13:00 hs y de 14:00 a 15:45 hs"
                        },
                        new
                        {
                            Id = 33,
                            Address = "Miralla y Batlle Ordóñez",
                            Lat = "-34.673770",
                            Locale = "Villa Lugano",
                            Long = "-58.468230",
                            Name = "CeSac 18",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 8:00 a 13:30 hs y 14:00 a 16:00 hs"
                        },
                        new
                        {
                            Id = 34,
                            Address = "Curapaligüe 1905",
                            Lat = "-34.642953",
                            Locale = "Nueva Pompeya",
                            Long = "-58.442266",
                            Name = "CeSac 19",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 8:30 a 12 hs y de 13 a 16 hs"
                        },
                        new
                        {
                            Id = 35,
                            Address = "Ana M. Janner y Charrúa",
                            Lat = "-34.649379",
                            Locale = "Villa Soldati",
                            Long = "-58.438103",
                            Name = "CeSac 20",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 12:30 hs y de 13:30 a 15:30 hs"
                        },
                        new
                        {
                            Id = 36,
                            Address = "Pasaje L entre Martínez Castro y Laguna",
                            Lat = "-34.657887",
                            Locale = "Villa Soldati",
                            Long = "-58.455484",
                            Name = "CeSac 24",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9:00 a 12:00 hs y 14:00 a 17:00 hs"
                        },
                        new
                        {
                            Id = 37,
                            Address = "Av. Riestra y Ana María Janner",
                            Lat = "-34.645813",
                            Locale = "Nueva Pompeya",
                            Long = "-58.433683",
                            Name = "CeSac 31",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 8:00 a 15:00 hs."
                        },
                        new
                        {
                            Id = 38,
                            Address = "Esteban Bonorino 1729 y Castañares",
                            Lat = "-34.645072",
                            Locale = "Flores",
                            Long = "-58.445485",
                            Name = "CeSac 40",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9:00 a 16:00 hs"
                        },
                        new
                        {
                            Id = 39,
                            Address = "Fonrouge 4377",
                            Lat = "-34.677722",
                            Locale = "Villa Lugano",
                            Long = "-58.466531",
                            Name = "CeSac 43",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes 8:30 a 12 hs y 13:15 a 14:30 hs"
                        },
                        new
                        {
                            Id = 40,
                            Address = "Saraza 4202",
                            Lat = "-34.660569",
                            Locale = "Barrio Samoré",
                            Long = "-58.467500",
                            Name = "CeSac 44",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes, martes, miércoles y viernes de 9 a 13 hs y de 14 a 16 hs. Jueves de 9 a 11 hs y de 14 a 16 hs"
                        },
                        new
                        {
                            Id = 41,
                            Address = "Av. Gral. Fernández de la Cruz 4402",
                            Lat = "-34.671621",
                            Locale = "Villa Lugano",
                            Long = "-58.457167",
                            Name = "Hospital Cecilia Grierson",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 9:00 a 12:00 hs. (4604-9000 Interno 5)"
                        },
                        new
                        {
                            Id = 42,
                            Address = "Terrada 5850",
                            Lat = "-34.576444",
                            Locale = "Villa Pueyrredón",
                            Long = "-58.509429",
                            Name = "CeSac 2",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes, miércoles y jueves de 8:00 a 12.30 hs, y de 14:00 a 16:00 hs. Martes y viernes de 8:00 a 12.30 hs."
                        },
                        new
                        {
                            Id = 43,
                            Address = "Olazábal 3960",
                            Lat = "-34.569800",
                            Locale = "Villa Urquiza",
                            Long = "-58.474324",
                            Name = "CeSac 12",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 08:30 a 13:00 hs, y de 14:00 a 16:30 hs."
                        },
                        new
                        {
                            Id = 44,
                            Address = "Arias 3783",
                            Lat = "-34.547747",
                            Locale = "Saavedra",
                            Long = "-58.486640",
                            Name = "CeSac 27",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:30 a 13:00 hs y de 14:00 a 16:00 hs"
                        },
                        new
                        {
                            Id = 45,
                            Address = "Gral. Urquiza 609",
                            Lat = "-34.617634",
                            Locale = "Balvanera",
                            Long = "-58.409436",
                            Name = "Hospital Ramos Mejía",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 16:00 hs."
                        },
                        new
                        {
                            Id = 46,
                            Address = "Agüero 940",
                            Lat = "-34.599020",
                            Locale = "Balvanera",
                            Long = "-58.410594",
                            Name = "CeSac 11",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 8:00 a 12:00 hs."
                        },
                        new
                        {
                            Id = 47,
                            Address = "Cochabamba 2626",
                            Lat = "-34.625335",
                            Locale = "Balvanera",
                            Long = "-58.402305",
                            Name = "CeSac 45",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9:00 a 12:00 hs"
                        },
                        new
                        {
                            Id = 48,
                            Address = "Pilar 950",
                            Lat = "-34.649343",
                            Locale = "Mataderos",
                            Long = "-58.515823",
                            Name = "Hospital Santojanni",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Todos los días, inclusive feriados, de 8:00 a 12:45 hs"
                        },
                        new
                        {
                            Id = 49,
                            Address = "Soldado de la Frontera 5144",
                            Lat = "-34.684538",
                            Locale = "Villa Lugano",
                            Long = "-58.464147",
                            Name = "CeSac 3",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 12:00 hs y de 13:00 a 16:00 hs"
                        },
                        new
                        {
                            Id = 50,
                            Address = "Alberdi y Pilar",
                            Lat = "-34.655557",
                            Locale = "Mataderos",
                            Long = "-58.507240",
                            Name = "CeSac 4",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8 a 13 hs y de 14 a 16 hs"
                        },
                        new
                        {
                            Id = 51,
                            Address = "Av. Piedrabuena 3140",
                            Lat = "-34.670523",
                            Locale = "Villa Lugano",
                            Long = "-58.495309",
                            Name = "CeSac 5",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8 a 12 hs y de 14 a 15.30 hs"
                        },
                        new
                        {
                            Id = 52,
                            Address = "2 de Abril y Montiel",
                            Lat = "-34.678111",
                            Locale = "Villa Lugano",
                            Long = "-58.491275",
                            Name = "CeSac 7",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8 a 13 hs y de 14 a 16 hs"
                        },
                        new
                        {
                            Id = 53,
                            Address = "Santander 5955",
                            Lat = "-34.673065",
                            Locale = "Villa Lugano",
                            Long = "-58.485930",
                            Name = "CeSac 28",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8 a 14 hs"
                        },
                        new
                        {
                            Id = 54,
                            Address = "Avenida General Paz 15378 Manzana 3 Casa 40",
                            Lat = "-34.683740",
                            Locale = "Villa Lugano",
                            Long = "-58.488679",
                            Name = "CeSac 29",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 9 a 11.30 hs y de 11 a 15 hs"
                        },
                        new
                        {
                            Id = 55,
                            Address = "Carhue y Av. De los Corrales",
                            Lat = "-34.665839",
                            Locale = "Mataderos",
                            Long = "-58.504135",
                            Name = "CeSac 37",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8 a 12:30 hs y 13:30 a 17 hs"
                        },
                        new
                        {
                            Id = 56,
                            Address = "Esteban de Luca 2151",
                            Lat = "-34.634832",
                            Locale = "Parque Patricios",
                            Long = "-58.402569",
                            Name = "Hospital Sardá",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8.30 a 16.30 hs"
                        },
                        new
                        {
                            Id = 57,
                            Address = "Av. Córdoba 5741",
                            Lat = "-34.586443",
                            Locale = "Villa Crespo",
                            Long = "-58.441751",
                            Name = "CeSac 33",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Turno mañana: lunes, miércoles y jueves de 8.30 a 12.30 hs; martes y viernes de 10 a 12.30 hs. Turno tarde: lunes a viernes de 14 a 16 hs,"
                        },
                        new
                        {
                            Id = 58,
                            Address = "Mercedes 1371/79",
                            Lat = "-34.621943",
                            Locale = "Villa Santa Rita",
                            Long = "-58.491833",
                            Name = "CeSac 36",
                            Phone = "0800-555-VACUNAPP",
                            Time = "Lunes a viernes de 8:30 hs a 12 hs y de 14 a 16.30 hs."
                        },
                        new
                        {
                            Id = 59,
                            Address = "Nueva York 3952",
                            Lat = "-34.599903",
                            Locale = "Villa Devoto",
                            Long = "-58.511231",
                            Name = "Hospital Zubizarreta",
                            Phone = "0800-555-VACUNAPP",
                            Time = "lunes a viernes de 8:00 a 14:00 hs"
                        });
                });

            modelBuilder.Entity("vacunAPP.Core.Domain.Person", b =>
                {
                    b.Property<string>("NIF")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ParentPersonNIF")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NIF");

                    b.HasIndex("ParentPersonNIF");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("vacunAPP.Core.Domain.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NIF")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Email");

                    b.HasAlternateKey("NIF")
                        .HasName("AlternateKey_NIF");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("vacunAPP.Core.Domain.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationType")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ExtraInfo")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Inyection")
                        .HasColumnType("nvarchar(500)");

                    b.Property<short>("Month")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Vaccine");
                });

            modelBuilder.Entity("vacunAPP.Core.Domain.Person", b =>
                {
                    b.HasOne("vacunAPP.Core.Domain.User", "User")
                        .WithOne("Person")
                        .HasForeignKey("vacunAPP.Core.Domain.Person", "NIF")
                        .HasPrincipalKey("vacunAPP.Core.Domain.User", "NIF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("vacunAPP.Core.Domain.Person", "ParentPerson")
                        .WithMany()
                        .HasForeignKey("ParentPersonNIF");
                });
#pragma warning restore 612, 618
        }
    }
}
