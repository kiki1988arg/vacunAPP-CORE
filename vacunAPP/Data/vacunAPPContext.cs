using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vacunAPP.Core.Domain;

namespace vacunAPP.Data
{
    public class vacunAPPContext : DbContext
    {
        public vacunAPPContext(DbContextOptions<vacunAPPContext> options)
            : base(options)
        {
        }

        public DbSet<vacunAPP.Core.Domain.Vaccine> Vaccine { get; set; }
        public DbSet<vacunAPP.Core.Domain.User> User { get; set; }
        public DbSet<vacunAPP.Core.Domain.Institute> Institute { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(eb =>
            {
                eb.HasKey(b => b.Id);
                eb.HasAlternateKey(b => b.NIF).HasName("AlternateKey_NIF");
                eb.HasAlternateKey(b => b.Email).HasName("AlternateKey_Email");
                eb.Property(b => b.Gender).HasColumnType("char(1)").IsRequired(true);
                eb.Property(b => b.Name).HasColumnType("nvarchar(50)").IsRequired(true);
                eb.Property(b => b.LastName).HasColumnType("nvarchar(50)").IsRequired(true);
                eb.Property(b => b.Email).HasColumnType("nvarchar(100)");
                eb.Property(b => b.password).HasColumnType("nvarchar(100)");
                eb.Property(b => b.PhotoUrl).HasColumnType("nvarchar(255)").IsRequired(true);
            });

            modelBuilder.Entity<Institute>(eb =>
            {
                eb.HasKey(b => b.Id);
                eb.Property(b => b.Id).ValueGeneratedOnAdd();                
                eb.Property(b => b.Name).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.Locale).HasColumnType("nvarchar(100)").IsRequired(true);
                eb.Property(b => b.Address).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.Time).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.Lat).HasColumnType("nvarchar(20)");
                eb.Property(b => b.Long).HasColumnType("nvarchar(20)");
                eb.Property(b => b.Phone).HasColumnType("nvarchar(20)");
            });

            modelBuilder.Entity<User>()
            .ToTable("Users");
            modelBuilder.Entity<Vaccine>()
            .HasData(
            new Vaccine { Id = 1, Name = "BCG" },
            new Vaccine { Id = 2, Name = "Hepatitis B" },
            new Vaccine { Id = 3, Name = "contra el Neumococo" },
            new Vaccine { Id = 4, Name = "la Quíntuple Prevalente DTP-HB-Hib:" },
            new Vaccine { Id = 5, Name = "la Sabin bivalente oral Meningococo" },
            new Vaccine { Id = 6, Name = "la Triple vital contra el Sarampión," },
            new Vaccine { Id = 7, Name = "Rubeóla, Paperas" },
            new Vaccine { Id = 8, Name = "la vacuna contra la gripe" },
            new Vaccine { Id = 9, Name = "Hepatitis A, Varicela" },
            new Vaccine { Id = 10, Name = "la Triple Bacteriano Celular," },
            new Vaccine { Id = 11, Name = "Triple Bacteriana Acelular" },
            new Vaccine { Id = 12, Name = "Doble Bacterinana," },
            new Vaccine { Id = 13, Name = "VPH contra el Virus Papiloma Humano" },
            new Vaccine { Id = 14, Name = "la Doble Vital" },
            new Vaccine { Id = 15, Name = "la vacuna contra la Fiebre Amarilla" },
            new Vaccine { Id = 16, Name = "la vacuna contra la Fiebre hemorrágica argentina." },
            new Vaccine { Id = 17, Name = "Covid-19" }
        );
            modelBuilder.Entity<Institute>()
            .HasData(
                 new Institute
                 {
                     Id = 1,
                     Name = "Hospital Álvarez",
                     Address = "Aranguren 2701 (Pabellón I)",
                     Locale = "Flores",
                     Time = "lunes a viernes de 8:00 a 12:00 hs.",
                     Lat = "-34.624292",
                     Long = "-58.469422"
                 },
              new Institute
              {
                  Id = 2,
                  Name = "CeSac 34",
                  Address = "Gral. José G. Artigas 2262",
                  Locale = "Villa del Parque",
                  Time = "lunes a viernes de 13:00 a 17:00 hs. Solicitar turno al 2821-3634",
                  Lat = "-34.606526",
                  Long = "-58.478186",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 3,
                  Name = "Hospital Argerich",
                  Address = "Almirante Brown 240",
                  Locale = "La Boca",
                  Time = "lunes a viernes de 8:00 a 12:00 hs",
                  Lat = "-34.628423",
                  Long = "-58.366048",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 4,
                  Name = "CeSac 9",
                  Address = "Irala 1254",
                  Locale = "La Boca",
                  Time = "lunes, martes, miércoles y viernes de 8:00 a 12:00 hs y de 14:00 a 17:00 hs",
                  Lat = "-34.640111",
                  Long = "-58.366091",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 5,
                  Name = "CeSac 15",
                  Address = "Humberto 1º 470",
                  Locale = "San Telmo",
                  Time = "lunes a viernes de 8.00 a 12.00 hs y de 14:00 a 17:00 hs",
                  Lat = "-34.620725",
                  Long = "-58.372486",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 6,
                  Name = "CeSac 41",
                  Address = "Ministro Brin 843",
                  Locale = "La Boca",
                  Time = "lunes a viernes de 8:00 a 13:00 hs y de 14:00 a 17:30 hs",
                  Lat = "-34.631301",
                  Long = "-58.357852",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 7,
                  Name = "Centro Boca - Barracas",
                  Address = "Regimiento Patricios 1941",
                  Locale = "La Boca",
                  Time = "lunes a viernes de 8:00 a 14:00 hs",
                  Lat = "-34.648849",
                  Long = "-58.368022",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 8,
                  Name = "Hospital de Clínicas",
                  Address = "Av. Córdoba 2351",
                  Locale = "Recoleta",
                  Time = "lunes a viernes de 8:00 a 14:00 hs",
                  Lat = "-34.599444",
                  Long = "-58.400681",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 9,
                  Name = "Hospital Durand",
                  Address = "Díaz Vélez 5044 Pabellón Romano",
                  Locale = "Caballito",
                  Time = "lunes a viernes de 8 a 15 hs. Sabados y domingos de 8 a 12 hs. y 13 a 17 hs.",
                  Lat = "-34.608875",
                  Long = "-58.437889",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 10,
                  Name = "CeSac 22",
                  Address = "Fragata Pres. Sarmiento 2152",
                  Locale = "Paternal",
                  Time = "lunes a viernes de 8:30 a 18:30 hs",
                  Lat = "-34.600874",
                  Long = "-58.459089",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 11,
                  Name = "CeSac 38",
                  Address = "Medrano 350",
                  Locale = "Almagro",
                  Time = "lunes a viernes 9:00 a 12:00 hs y de 14:00 a 16:00 hs",
                  Lat = "-34.606614",
                  Long = "-58.421452",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 12,
                  Name = "Hospital Elizalde",
                  Address = "Montes de Oca 40",
                  Locale = "Barracas",
                  Time = "Lunes a viernes de 8 a 15 hs",
                  Lat = "-34.628900",
                  Long = "-58.377635",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 13,
                  Name = "Hospital Fernández",
                  Address = "Cerviño 3356",
                  Locale = "Palermo",
                  Time = "Lunes a viernes de 8 a 16 hs",
                  Lat = "-34.581139",
                  Long = "-58.406896",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 14,
                  Name = "CeSac 17",
                  Address = "El Salvador 4087 Escuela N°9",
                  Locale = "Palermo",
                  Time = "lunes a viernes de 9:00 a 16:00 hs",
                  Lat = "-34.592726",
                  Long = "-58.420525",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 15,
                  Name = "CeSac 21",
                  Address = "Gendarmería Nacional 522",
                  Locale = "Retiro",
                  Time = "lunes a viernes de 8:30 a 12:30 hs",
                  Lat = "-34.584676",
                  Long = "-58.373258",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 16,
                  Name = "CeSac 25",
                  Address = "E.E.U.U. de Brasil y Antártida Argentina Escuela 25",
                  Locale = "Palermo",
                  Time = "lunes a viernes de 9:00 a 15.00 hs",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute{
                 Id=17,
                Name="CeSac 26",
                Address="Gurruchaga 1939",
                Locale="Villa Crespo",
                Time="lunes a viernes de 8:30 a 14:00 hs. Solicitando turno al 4897-2156",
                Lat="-34.587150",
                Long="-58.425744",
                Phone="0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 18,
                  Name = "CeSac 47",
                  Address = "Calle playón (ex galpón SIC)",
                  Locale = "Barrio 31 (Retiro)",
                  Time = "lunes a viernes 9:00 a 15:00 hs",
                  Lat = "-34.583691",
                  Long = "-58.378639",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 19,
                  Name = "Hospital Garrahan",
                  Address = "Combate de Los Pozos 1881",
                  Locale = "Constitución",
                  Time = "lunes a viernes de 8:00 a 15:00 hs",
                  Lat = "-34.630832",
                  Long = "-58.391527",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 20,
                  Name = "Hospital Gutiérrez",
                  Address = "Sanchez De Bustamante 1330",
                  Locale = "Palermo",
                  Time = "lunes a viernes de 8:30 a 14:30 hs",
                  Lat = "-34.594851",
                  Long = "-58.412740",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 21,
                  Name = "Hospital Muñiz",
                  Address = "Uspallata 2272",
                  Locale = "Parque Patricios",
                  Time = "lunes a viernes de 8:00 a 15:00 hs.",
                  Lat = "-34.637233",
                  Long = "-58.393042",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 22,
                  Name = "CeSac 1",
                  Address = "Vélez Sarsfield 1271",
                  Locale = "Barracas",
                  Time = "lunes a viernes de 8:30 a 16:30 hs",
                  Lat = "-34.649026",
                  Long = "-58.389308",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 23,
                  Name = "CeSac 8",
                  Address = "Osvaldo Cruz 3485",
                  Locale = "Barracas",
                  Time = "lunes a viernes de 8:30 a 16:30 hs",
                  Lat = "-34.655839",
                  Long = "-58.395274",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 24,
                  Name = "CeSac 10",
                  Address = "Amancio Alcorta 1402",
                  Locale = "Barracas",
                  Time = "lunes a viernes de 8:30 a 16:30 hs",
                  Lat = "-34.633349",
                  Long = "-58.383729",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 25,
                  Name = "CeSac 16",
                  Address = "Osvaldo Cruz 2045",
                  Locale = "Barracas",
                  Time = "lunes a viernes de 8:30 a 16:30 hs",
                  Lat = "-34.651815",
                  Long = "-58.374546",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 26,
                  Name = "CeSac 30",
                  Address = "Amancio Alcorta 2900",
                  Locale = "Parque Patricios",
                  Time = "lunes a viernes de 9:00 a 13:00 hs",
                  Lat = "-34.645742",
                  Long = "-58.401625",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 27,
                  Name = "CeSac 32",
                  Address = "Charrúa 2900",
                  Locale = "Nueva Pompeya",
                  Time = "lunes a viernes de 08:30 a 16:30 hs",
                  Lat = "-34.654251",
                  Long = "-58.431151",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 28,
                  Name = "CeSac 35",
                  Address = "Osvaldo Cruz y Zabaleta",
                  Locale = "Barracas",
                  Time = "lunes a viernes de 8:30 a 16.30 hs",
                  Lat = "-34.656475",
                  Long = "-58.399222",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 29,
                  Name = "CeSac 39",
                  Address = "24 de November 1679",
                  Locale = "Parque Patricios",
                  Time = "lunes a viernes de 8:30 a 16:30 hs",
                  Lat = "-34.631019",
                  Long = "-58.409865",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 30,
                  Name = "Hospital Piñero",
                  Address = "Varela 1301",
                  Locale = "Flores",
                  Time = "Lunes a viernes de 8:00 a 12:00 hs.",
                  Lat = "-34.644118",
                  Long = "-58.453681",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 31,
                  Name = "CeSac 6",
                  Address = "M. Acosta y Roca",
                  Locale = "Villa Soldati",
                  Time = "Lunes a viernes de 8:30 a 13:00 hs y de 14:00 a 15:30 hs",
                  Lat = "-34.666766",
                  Long = "-58.440949",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 32,
                  Name = "CeSac 13",
                  Address = "Directorio 4210",
                  Locale = "Parque Avellaneda",
                  Time = "lunes a viernes 8:30 a 13:00 hs y de 14:00 a 15:45 hs",
                  Lat = "-34.643236",
                  Long = "-58.482134",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 33,
                  Name = "CeSac 18",
                  Address = "Miralla y Batlle Ordóñez",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes 8:00 a 13:30 hs y 14:00 a 16:00 hs",
                  Lat = "-34.673770",
                  Long = "-58.468230",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 34,
                  Name = "CeSac 19",
                  Address = "Curapaligüe 1905",
                  Locale = "Nueva Pompeya",
                  Time = "lunes a viernes 8:30 a 12 hs y de 13 a 16 hs",
                  Lat = "-34.642953",
                  Long = "-58.442266",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 35,
                  Name = "CeSac 20",
                  Address = "Ana M. Janner y Charrúa",
                  Locale = "Villa Soldati",
                  Time = "lunes a viernes de 8:30 a 12:30 hs y de 13:30 a 15:30 hs",
                  Lat = "-34.649379",
                  Long = "-58.438103",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 36,
                  Name = "CeSac 24",
                  Address = "Pasaje L entre Martínez Castro y Laguna",
                  Locale = "Villa Soldati",
                  Time = "lunes a viernes de 9:00 a 12:00 hs y 14:00 a 17:00 hs",
                  Lat = "-34.657887",
                  Long = "-58.455484",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 37,
                  Name = "CeSac 31",
                  Address = "Av. Riestra y Ana María Janner",
                  Locale = "Nueva Pompeya",
                  Time = "lunes a viernes 8:00 a 15:00 hs.",
                  Lat = "-34.645813",
                  Long = "-58.433683",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 38,
                  Name = "CeSac 40",
                  Address = "Esteban Bonorino 1729 y Castañares",
                  Locale = "Flores",
                  Time = "lunes a viernes de 9:00 a 16:00 hs",
                  Lat = "-34.645072",
                  Long = "-58.445485",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 39,
                  Name = "CeSac 43",
                  Address = "Fonrouge 4377",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes 8:30 a 12 hs y 13:15 a 14:30 hs",
                  Lat = "-34.677722",
                  Long = "-58.466531",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 40,
                  Name = "CeSac 44",
                  Address = "Saraza 4202",
                  Locale = "Barrio Samoré",
                  Time = "lunes, martes, miércoles y viernes de 9 a 13 hs y de 14 a 16 hs. Jueves de 9 a 11 hs y de 14 a 16 hs",
                  Lat = "-34.660569",
                  Long = "-58.467500",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 41,
                  Name = "Hospital Cecilia Grierson",
                  Address = "Av. Gral. Fernández de la Cruz 4402",
                  Locale = "Villa Lugano",
                  Time = "Lunes a viernes de 9:00 a 12:00 hs. (4604-9000 Interno 5)",
                  Lat = "-34.671621",
                  Long = "-58.457167",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 42,
                  Name = "CeSac 2",
                  Address = "Terrada 5850",
                  Locale = "Villa Pueyrredón",
                  Time = "Lunes, miércoles y jueves de 8:00 a 12.30 hs, y de 14:00 a 16:00 hs. Martes y viernes de 8:00 a 12.30 hs.",
                  Lat = "-34.576444",
                  Long = "-58.509429",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 43,
                  Name = "CeSac 12",
                  Address = "Olazábal 3960",
                  Locale = "Villa Urquiza",
                  Time = "Lunes a viernes de 08:30 a 13:00 hs, y de 14:00 a 16:30 hs.",
                  Lat = "-34.569800",
                  Long = "-58.474324",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 44,
                  Name = "CeSac 27",
                  Address = "Arias 3783",
                  Locale = "Saavedra",
                  Time = "lunes a viernes de 8:30 a 13:00 hs y de 14:00 a 16:00 hs",
                  Lat = "-34.547747",
                  Long = "-58.486640",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 45,
                  Name = "Hospital Ramos Mejía",
                  Address = "Gral. Urquiza 609",
                  Locale = "Balvanera",
                  Time = "lunes a viernes de 8:00 a 16:00 hs.",
                  Lat = "-34.617634",
                  Long = "-58.409436",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 46,
                  Name = "CeSac 11",
                  Address = "Agüero 940",
                  Locale = "Balvanera",
                  Time = "Lunes a viernes de 8:00 a 12:00 hs.",
                  Lat = "-34.599020",
                  Long = "-58.410594",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 47,
                  Name = "CeSac 45",
                  Address = "Cochabamba 2626",
                  Locale = "Balvanera",
                  Time = "lunes a viernes de 9:00 a 12:00 hs",
                  Lat = "-34.625335",
                  Long = "-58.402305",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 48,
                  Name = "Hospital Santojanni",
                  Address = "Pilar 950",
                  Locale = "Mataderos",
                  Time = "Todos los días, inclusive feriados, de 8:00 a 12:45 hs",
                  Lat = "-34.649343",
                  Long = "-58.515823",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 49,
                  Name = "CeSac 3",
                  Address = "Soldado de la Frontera 5144",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes de 8:00 a 12:00 hs y de 13:00 a 16:00 hs",
                  Lat = "-34.684538",
                  Long = "-58.464147",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 50,
                  Name = "CeSac 4",
                  Address = "Alberdi y Pilar",
                  Locale = "Mataderos",
                  Time = "lunes a viernes de 8 a 13 hs y de 14 a 16 hs",
                  Lat = "-34.655557",
                  Long = "-58.507240",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 51,
                  Name = "CeSac 5",
                  Address = "Av. Piedrabuena 3140",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes de 8 a 12 hs y de 14 a 15.30 hs",
                  Lat = "-34.670523",
                  Long = "-58.495309",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 52,
                  Name = "CeSac 7",
                  Address = "2 de Abril y Montiel",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes de 8 a 13 hs y de 14 a 16 hs",
                  Lat = "-34.678111",
                  Long = "-58.491275",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 53,
                  Name = "CeSac 28",
                  Address = "Santander 5955",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes de 8 a 14 hs",
                  Lat = "-34.673065",
                  Long = "-58.485930",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 54,
                  Name = "CeSac 29",
                  Address = "Avenida General Paz 15378 Manzana 3 Casa 40",
                  Locale = "Villa Lugano",
                  Time = "lunes a viernes de 9 a 11.30 hs y de 11 a 15 hs",
                  Lat = "-34.683740",
                  Long = "-58.488679",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 55,
                  Name = "CeSac 37",
                  Address = "Carhue y Av. De los Corrales",
                  Locale = "Mataderos",
                  Time = "lunes a viernes de 8 a 12:30 hs y 13:30 a 17 hs",
                  Lat = "-34.665839",
                  Long = "-58.504135",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 56,
                  Name = "Hospital Sardá",
                  Address = "Esteban de Luca 2151",
                  Locale = "Parque Patricios",
                  Time = "lunes a viernes de 8.30 a 16.30 hs",
                  Lat = "-34.634832",
                  Long = "-58.402569",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 57,
                  Name = "CeSac 33",
                  Address = "Av. Córdoba 5741",
                  Locale = "Villa Crespo",
                  Time = "Turno mañana: lunes, miércoles y jueves de 8.30 a 12.30 hs; martes y viernes de 10 a 12.30 hs. Turno tarde: lunes a viernes de 14 a 16 hs,",
                  Lat = "-34.586443",
                  Long = "-58.441751",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 58,
                  Name = "CeSac 36",
                  Address = "Mercedes 1371/79",
                  Locale = "Villa Santa Rita",
                  Time = "Lunes a viernes de 8:30 hs a 12 hs y de 14 a 16.30 hs.",
                  Lat = "-34.621943",
                  Long = "-58.491833",
                  Phone = "0800-555-VACUNAPP"
              },
              new Institute
              {
                  Id = 59,
                  Name = "Hospital Zubizarreta",
                  Address = "Nueva York 3952",
                  Locale = "Villa Devoto",
                  Time = "lunes a viernes de 8:00 a 14:00 hs",
                  Lat = "-34.599903",
                  Long = "-58.511231",
                  Phone = "0800-555-VACUNAPP"
              }     

            );

        }
    }
}
