﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vacunAPP.Data;

namespace vacunAPP.Migrations
{
    [DbContext(typeof(vacunAPPContext))]
    partial class vacunAPPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vacunAPP.Core.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BornDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsVerify")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NIF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("vacunAPP.Core.Domain.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vaccine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BCG"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hepatitis B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "contra el Neumococo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "la Quíntuple Prevalente DTP-HB-Hib:"
                        },
                        new
                        {
                            Id = 5,
                            Name = "la Sabin bivalente oral Meningococo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "la Triple vital contra el Sarampión,"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Rubeóla, Paperas"
                        },
                        new
                        {
                            Id = 8,
                            Name = "la vacuna contra la gripe"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Hepatitis A, Varicela"
                        },
                        new
                        {
                            Id = 10,
                            Name = "la Triple Bacteriano Celular,"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Triple Bacteriana Acelular"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Doble Bacterinana,"
                        },
                        new
                        {
                            Id = 13,
                            Name = "VPH contra el Virus Papiloma Humano"
                        },
                        new
                        {
                            Id = 14,
                            Name = "la Doble Vital"
                        },
                        new
                        {
                            Id = 15,
                            Name = "la vacuna contra la Fiebre Amarilla"
                        },
                        new
                        {
                            Id = 16,
                            Name = "la vacuna contra la Fiebre hemorrágica argentina."
                        },
                        new
                        {
                            Id = 17,
                            Name = "Covid-19"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
