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
        public DbSet<vacunAPP.Core.Domain.Center> Center { get; set; }
        public DbSet<vacunAPP.Core.Domain.Person> Person { get; set; }
        public DbSet<vacunAPP.Core.Domain.Professional> Profesional { get; set; }
        public DbSet<vacunAPP.Core.Domain.Institute> Institute { get; set; }

        public DbSet<vacunAPP.Core.Domain.Notebook> Notebook { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(eb =>
            {
                eb.HasKey(b => b.Email);
                eb.HasAlternateKey(b => b.NIF).HasName("AlternateKey_NIF");
                eb.Property(b => b.Email).HasColumnType("nvarchar(100)").IsRequired(true);
                eb.Property(b => b.password).HasColumnType("nvarchar(100)").IsRequired(true);
                eb.Property(b => b.NIF).HasColumnType("nvarchar(50)").IsRequired(true);
            });

            modelBuilder.Entity<Person>(eb =>
            {
                eb.HasKey(b => b.NIF);
                eb.Property(b => b.Gender).HasColumnType("char(1)").IsRequired(true);
                eb.Property(b => b.NIF).HasColumnType("nvarchar(50)").IsRequired(true);
                eb.Property(b => b.Name).HasColumnType("nvarchar(50)").IsRequired(true);
                eb.Property(b => b.LastName).HasColumnType("nvarchar(50)").IsRequired(true);
                eb.Property(b => b.ParentPersonNIF).HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Person>()
            .HasOne(a => a.User)
            .WithOne(b => b.Person)
            .HasForeignKey<User>(b => b.NIF)
            .IsRequired(false)
            .HasPrincipalKey<Person>(c => c.NIF);

            modelBuilder.Entity<Notebook>()
            .HasOne(a => a.Person)
            .WithMany(b => b.Notebooks)
            .HasForeignKey(a => a.NIF);

            modelBuilder.Entity<Center>(eb =>
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

            modelBuilder.Entity<Professional>(eb =>
            {
                eb.HasKey(b => b.Id);
                eb.Property(b => b.Id).ValueGeneratedOnAdd();
                eb.Property(b => b.Name).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.LastName).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.Name).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.NIF).HasColumnType("nvarchar(10)").IsRequired(true);
                eb.Property(b => b.Function).HasColumnType("nvarchar(25)").IsRequired(true);
                eb.Property(b => b.Email).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.Password).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.InstituteId).HasColumnType("int").IsRequired(true);
            });

            modelBuilder.Entity<Institute>(eb =>
            {
                eb.HasKey(b => b.Id);
                eb.Property(b => b.Id).ValueGeneratedOnAdd();
                eb.Property(b => b.InstituteName).HasColumnType("nvarchar(250)").IsRequired(true);
                eb.Property(b => b.CUIT).HasColumnType("nvarchar(25)").IsRequired(true);
                eb.Property(b => b.License).HasColumnType("nvarchar(25)").IsRequired(true);
                eb.Property(b => b.Contract).HasColumnType("nvarchar(25)").IsRequired(true);
                eb.Property(b => b.CreatedAt).HasColumnType("DateTime2").IsRequired(true);
            });



            modelBuilder.Entity<Vaccine>(eb =>
            {
                eb.HasKey(b => b.Id);
                eb.Property(b => b.Id).ValueGeneratedOnAdd();
                eb.Property(b => b.Name).HasColumnType("nvarchar(500)");
                eb.Property(b => b.Description).HasColumnType("nvarchar(500)");
                eb.Property(b => b.Month).HasColumnType("smallint");
                eb.Property(b => b.ApplicationType).HasColumnType("nvarchar(500)");
                eb.Property(b => b.ExtraInfo).HasColumnType("nvarchar(500)");
                eb.Property(b => b.Inyection).HasColumnType("nvarchar(500)");
            });

            modelBuilder.Entity<Notebook>(eb =>
            {
                eb.HasKey(b => b.Id);
                eb.Property(b => b.Id).ValueGeneratedOnAdd();
                eb.Property(b => b.NIF).HasColumnType("nvarchar(50)");
            });


            //modelBuilder.Entity<PersonVaccine>()
            //.HasKey(bc => new { bc.PersonId, bc.VaccineId });
            //modelBuilder.Entity<PersonVaccine>()
            //    .HasOne(bc => bc.Person)
            //    .WithMany(b => b.PersonVaccine)
            //    .HasForeignKey(bc => bc.PersonId);
            //modelBuilder.Entity<PersonVaccine>()
            //    .HasOne(bc => bc.Vaccine)
            //    .WithMany(c => c.PersonVaccine)
            //    .HasForeignKey(bc => bc.VaccineId);

            modelBuilder.Entity<User>()
            .ToTable("Users");




           modelBuilder.Entity<Vaccine>()
           .HasData(
                     new Vaccine
                     {
                         Id = 1,
                         Month = 0,
                         Name = "BCG",
                         Inyection = "(única dosis)",
                         Description = "Previene las formas invasivas de tuberculosis. Debe aplicarse antes de egresar de la maternidad.",
                         ApplicationType = "Forma de aplicación: Intradérmica.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 2,
                         Month = 0,
                         Name = "Hepatitis B",
                         Inyection = "(dosis neonatal)",
                         Description = "Previene la transmisión vertical (de la madre al bebé) de la hepatitis B. Debe aplicarse en las primeras 12 horas de vida.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 3,
                         Month = 2,
                         Name = "Neumococo Conjugada",
                         Inyection = "(1° dosis)",
                         Description = "Previene meningitis, neumonía y sepsis causada por los 13 serotipos de neumococo contenidos en la vacuna.",
                         ApplicationType = "Forma de aplicación: Intramuscular",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 4,
                         Month = 2,
                         Name = "Quíntuple o Pentavalente Celular",
                         Inyection = "(1° dosis)",
                         Description = "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 5,
                         Month = 2,
                         Name = "Polio IPV",
                         Inyection = "(1° dosis)",
                         Description = "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 6,
                         Month = 2,
                         Name = "Rotavirus",
                         Inyection = "(1° dosis)",
                         Description = "Previene la diarrea por rotavirus.",
                         ApplicationType = "Forma de aplicación: Vía oral.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 7,
                         Month = 3,
                         Name = "Meningococo Conjugada Cuadrivalente",
                         Inyection = "(1° dosis)",
                         Description = "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 8,
                         Month = 4,
                         Name = "Neumococo conjugada",
                         Inyection = "(2° dosis)",
                         Description = "Previene meningitis, neumonía y sepsis causada por los 13 serotipos de neumococo contenidos en la vacuna.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 9,
                         Month = 4,
                         Name = "Quíntuple o Pentavalente",
                         Inyection = "(2° dosis)",
                         Description = "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 10,
                         Month = 4,
                         Name = "Polio IPV",
                         Inyection = "(2° dosis)",
                         Description = "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 11,
                         Month = 4,
                         Name = "Rotavirus",
                         Inyection = "(2° dosis)",
                         Description = "Previene la diarrea por rotavirus.",
                         ApplicationType = "Forma de aplicación: Vía oral.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 12,
                         Month = 5,
                         Name = "Meningococo Conjugada Cuadrivalente",
                         Inyection = "(2° dosis)",
                         Description = "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 13,
                         Month = 6,
                         Name = "Quíntuple o Pentavalente",
                         Inyection = "(3° dosis)",
                         Description = "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 14,
                         Month = 6,
                         Name = "Polio IPV",
                         Inyection = "(3° dosis)",
                         Description = "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 15,
                         Month = 6,
                         Name = "Gripe",
                         Inyection = "(si es la primera aplicación son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)",
                         Description = "Previene las complicaciones y muerte causadas por el virus de la influenza.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 16,
                         Month = 12,
                         Name = "Neumococo Conjugada",
                         Inyection = "(refuerzo)",
                         Description = "Previene meningitis, neumonía y sepsis causada por los 13 serotipos de neumococo contenidos en la vacuna.",
                         ApplicationType = "Forma de aplicación: Inyectable.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 17,
                         Month = 12,
                         Name = "Hepatitis A",
                         Inyection = "(única dosis)",
                         Description = "Previene hepatitis A y sus complicaciones.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 18,
                         Month = 12,
                         Name = "Triple Viral",
                         Inyection = "(1° dosis)",
                         Description = "Previene sarampión, rubeola y paperas.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 19,
                         Month = 12,
                         Name = "Gripe",
                         Inyection = "(si es la primera aplicación son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)",
                         Description = "Previene las complicaciones y muerte causadas por el virus de la influenza.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 20,
                         Month = 15,
                         Name = "Meningococo Conjugada Cuadrivalente",
                         Inyection = "(refuerzo)",
                         Description = "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 21,
                         Month = 15,
                         Name = "Varicela",
                         Inyection = "(única dosis)",
                         Description = "Previene varicela y sus complicaciones.",
                         ApplicationType = "Forma de aplicación: Subcutánea, Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 22,
                         Month = 192,
                         Name = "Cuádruple o Quíntuple Pentavalente Celular",
                         Inyection = "(1° refuerzo)",
                         Description = "Previene difteria, tétanos, tos convulsa, hepatitis B, Haemophilus influenzae tipo b.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 23,
                         Month = 192,
                         Name = "Gripe",
                         Inyection = "(si es la primera vez son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)",
                         Description = "Previene las complicaciones y muerte causadas por el virus de la influenza.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 24,
                         Month = 18,
                         Name = "Fiebre amarilla",
                         Inyection = "(1° dosis)",
                         Description = "Previene fiebre amarilla, enfermedad causada por un virus que se transmite a través de la picadura de mosquitos. Las zonas de riesgo en Argentina son Misiones, Formosa, norte de Corrientes, y algunos departamentos de Chaco, Salta y Jujuy.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = "EXCLUSIVO ZONAS DE RIESGO"
                     },
                     new Vaccine
                     {
                         Id = 25,
                         Month = 18,
                         Name = "Gripe",
                         Inyection = "(si es la primera vez son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)",
                         Description = "Previene las complicaciones y muerte causadas por el virus de la influenza.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 26,
                         Month = 24,
                         Name = "Gripe",
                         Inyection = "(si es la primera vez son dos dosis separadas por 4 semanas y luego una dosis anual a todos los niños entre 6 y 24 meses)",
                         Description = "Previene las complicaciones y muerte causadas por el virus de la influenza.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 27,
                         Month = 72,
                         Name = "Polio IPV",
                         Inyection = "(1° refuerzo)",
                         Description = "Previene poliomelitis causada por los poliovirus tipo 1, 2 y 3 (trivalente).",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 28,
                         Month = 72,
                         Name = "Triple Viral",
                         Inyection = "(2° dosis)",
                         Description = "Previene sarampión, rubeola y paperas.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 29,
                         Month = 72,
                         Name = "Triple Bacteriana Celular DTP",
                         Inyection = "(2° refuerzo)",
                         Description = "Previene difteria, tétanos y tos convulsa.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 30,
                         Month = 132,
                         Name = "Meningococo Conjugada Cuadrivalente",
                         Inyection = "(única dosis)",
                         Description = "Previene meningitis y sepsis (infección generalizada) causada por los serotipos de meningococo contenidos en la vacuna A,C,W e Y y sus posibles secuelas.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 31,
                         Month = 132,
                         Name = "Triple Bacteriana Acelular dpaT",
                         Inyection = "(refuerzo)",
                         Description = "Previene difteria, tétanos y tos convulsa.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 32,
                         Month = 132,
                         Name = "VPH (2 dosis)",
                         Inyection = "(2° dosis)",
                         Description = "Previene la infección por el Virus del Papiloma Humano (genotipos 6 y 11 de bajo riesgo y 16 y 18 de alto riesgo), principal causa de cáncer de cuello de útero, otros cánceres relacionados y verrugas genitales.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 33,
                         Month = 132,
                         Name = "Fiebre amarilla",
                         Inyection = "(refuerzo)",
                         Description = "Previene fiebre amarilla, enfermedad causada por un virus que se transmite a través de la picadura de mosquitos. Las zonas de riesgo en Argentina son Misiones, Formosa, norte de Corrientes, y algunos departamentos de Chaco, Salta y Jujuy.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = "EXCLUSIVO ZONAS DE RIESGO"
                     },
                     new Vaccine
                     {
                         Id = 34,
                         Month = 132,
                         Name = "Hepatitis B",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)",
                         Description = "Previene hepatitis B.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 35,
                         Month = 132,
                         Name = "Triple Viral",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación completo -dos dosis después del año- se recomienda iniciarlo o completarlo)",
                         Description = "Previene sarampión, rubeola y paperas.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 36,
                         Month = 180,
                         Name = "Hepatitis B",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)",
                         Description = "Previene hepatitis B.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 37,
                         Month = 180,
                         Name = "Doble Viral SR o Triple Viral SRP",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación -dos dosis después del año- se recomienda iniciarlo o completarlo)",
                         Description = "Previene sarampión, rubeola y paperas.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 38,
                         Month = 180,
                         Name = "Fiebre hemorrágica argentina",
                         Inyection = "(única dosis)",
                         Description = "Previene fiebre hemorrágica argentina, que es una enfermedad infecciosa endémica en el noroeste de la provincia de Buenos Aires, sur de Córdoba, sur de Santa fe y norte de La Pampa.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = "EXCLUSIVO ZONAS DE RIESGO"
                     },
                     new Vaccine
                     {
                         Id = 39,
                         Month = 216,
                         Name = "Hepatitis B",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)",
                         Description = "Previene hepatitis B.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 40,
                         Month = 216,
                         Name = "Triple Viral",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación se recomienda iniciarlo o completarlo. Las personas que nacieron antes de 1965 se consideran inmunes. Las que nacieron después de 1965 tienen que vacunarse solo si no tienen las dos dosis de la infancia o si tienen serología negativa)",
                         Description = "Previene sarampión, rubeola y paperas.",
                         ApplicationType = "Forma de aplicación: Subcutánea.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 41,
                         Month = 216,
                         Name = "Doble Bacteriana o Doble Adulto",
                         Inyection = "(refuerzo cada 10 años)",
                         Description = "Previene difteria y tétanos.",
                         ApplicationType = "Forma de aplicación: Inyectable.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 42,
                         Month = 216,
                         Name = "Fiebre hemorrágica argentina",
                         Inyection = "(única dosis)",
                         Description = "Previene fiebre hemorrágica argentina, que es una enfermedad infecciosa endémica en el noroeste de la provincia de Buenos Aires, sur de Córdoba, sur de Santa fe y norte de La Pampa.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = "EXCLUSIVO ZONAS DE RIESGO"
                     },
                     new Vaccine
                     {
                         Id = 43,
                         Month = 780,
                         Name = "Hepatitis B",
                         Inyection = "(en caso de no haber recibido el esquema de vacunación completo -tres dosis- se recomienda iniciarlo o completarlo)",
                         Description = "Previene hepatitis B.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 44,
                         Month = 780,
                         Name = "Doble Bacteriana o Doble Adulto",
                         Inyection = "(refuerzo cada 10 años)",
                         Description = "Previene difteria y tétanos.",
                         ApplicationType = "Forma de aplicación: Inyectable.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 45,
                         Month = 780,
                         Name = "Gripe",
                         Inyection = "(dosis anual)",
                         Description = "Previene las complicaciones y muerte causadas por el virus de la influenza.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     },
                     new Vaccine
                     {
                         Id = 46,
                         Month = 0,
                         Name = "Covid-19",
                         Inyection = "(dosis anual)",
                         Description = "Previene las complicaciones y muerte causadas por el virus Covid-19.",
                         ApplicationType = "Forma de aplicación: Intramuscular.",
                         ExtraInfo = ""
                     }

           );

            modelBuilder.Entity<Center>()
            .HasData(
                 new Center
                 {
                     Id = 1,
                     Name = "Hospital Álvarez",
                     Address = "Aranguren 2701 (Pabellón I)",
                     Locale = "Flores",
                     Time = "lunes a viernes de 8:00 a 12:00 hs.",
                     Lat = "-34.624292",
                     Long = "-58.469422"
                 },
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
              {
                  Id = 16,
                  Name = "CeSac 25",
                  Address = "E.E.U.U. de Brasil y Antártida Argentina Escuela 25",
                  Locale = "Palermo",
                  Time = "lunes a viernes de 9:00 a 15.00 hs",
                  Phone = "0800-555-VACUNAPP"
              },
              new Center
              {
                  Id = 17,
                  Name = "CeSac 26",
                  Address = "Gurruchaga 1939",
                  Locale = "Villa Crespo",
                  Time = "lunes a viernes de 8:30 a 14:00 hs. Solicitando turno al 4897-2156",
                  Lat = "-34.587150",
                  Long = "-58.425744",
                  Phone = "0800-555-VACUNAPP"
              },
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
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
              new Center
              {
                  Id = 59,
                  Name = "Hospital Zubizarreta",
                  Address = "Nueva York 3952",
                  Locale = "Villa Devoto",
                  Time = "lunes a viernes de 8:00 a 14:00 hs",
                  Lat = "-34.599903",
                  Long = "-58.511231",
                  Phone = "0800-555-VACUNAPP"
              },
               new Center
               {
                Id = 999999,
                Name = "Auto gestionada",
                Address = "Auto gestionada",
                Locale = "0",
                Time = "0",
                Lat = "0",
                Long = "0",
                Phone = "0"
               }

            );

            modelBuilder.Entity<Institute>()
            .HasData(
                new Institute
                {
                    Id = 999999,
                    InstituteName = "-",
                    CUIT = "-",
                    License = "-",
                    Contract = "-",
                    CreatedAt = DateTime.Parse("2020-01-01 00:00:00.000")
                }
            ) ;

            modelBuilder.Entity<Professional>()
            .HasData(
                new Professional
                {
                    Id = 999999,
                    MN = "999999",
                    Name = "-",
                    LastName = "-",
                    NIF = "-",
                    Function = "-",
                    InstituteId = 999999,
                    Email = "-",
                    Password = "-",
                },
                new Professional
                {
                    Id = 3,
                    MN = "5132135",
                    Name = "Pedro",
                    LastName = "Kahn",
                    NIF = "5132135",
                    Function = "P",
                    InstituteId = 999999,
                    Email = "Pedro@Kahn.com",
                    Password = "Pedro@Kahn.com",
                }
            );

        }
    }
}
