﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(DbAppContext))]
    partial class DbAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Archivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<float>("Tamanio")
                        .HasColumnType("float");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Archivo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
