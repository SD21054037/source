﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

#nullable disable

namespace TodoApi.Migrations
{
    [DbContext(typeof(yourDbContext))]
    partial class yourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.dbGebruiker", b =>
                {
                    b.Property<int>("GebruikerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GebruikerID"));

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Datum_Registratie")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Type_Gebruiker")
                        .HasColumnType("int");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GebruikerID");

                    b.ToTable("Gebruikers");
                });
#pragma warning restore 612, 618
        }
    }
}
