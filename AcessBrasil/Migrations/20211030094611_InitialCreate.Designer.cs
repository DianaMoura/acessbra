﻿// <auto-generated />
using System;
using AcessBrasil.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcessBrasil.Migrations
{
    [DbContext(typeof(VeiculosContext))]
    [Migration("20211030094611_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AcessBrasil.Models.Carro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDMarca")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("AcessBrasil.Models.Marca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarroID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CarroID");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("AcessBrasil.Models.Marca", b =>
                {
                    b.HasOne("AcessBrasil.Models.Carro", null)
                        .WithMany("Marcas")
                        .HasForeignKey("CarroID");
                });

            modelBuilder.Entity("AcessBrasil.Models.Carro", b =>
                {
                    b.Navigation("Marcas");
                });
#pragma warning restore 612, 618
        }
    }
}
