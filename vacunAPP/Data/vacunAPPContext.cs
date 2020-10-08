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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}
