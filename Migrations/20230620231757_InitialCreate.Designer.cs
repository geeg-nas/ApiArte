﻿// <auto-generated />
using ApiArte.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiArte.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230620231757_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiArte.Models.Arte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Data")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artista = "Leonardo da Vinci",
                            Categoria = "Pintura",
                            Data = 1503,
                            Descricao = "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci",
                            Localizacao = "Museu lo Louvre",
                            Titulo = "Monalisa"
                        },
                        new
                        {
                            Id = 2,
                            Artista = "Arthur Sasse",
                            Categoria = "Fotográfia",
                            Data = 1951,
                            Descricao = "Uma das imagens mais conhecidas da história é a do físico Albert Einstein mostrando a língua.",
                            Localizacao = "indefinida",
                            Titulo = "Einstein mostrando a língua"
                        },
                        new
                        {
                            Id = 3,
                            Artista = "Leonardo da Vinci",
                            Categoria = "Pintura",
                            Data = 1503,
                            Descricao = "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci",
                            Localizacao = "Museu lo Louvre",
                            Titulo = "Monalisa"
                        },
                        new
                        {
                            Id = 4,
                            Artista = "Leonardo da Vinci",
                            Categoria = "Pintura",
                            Data = 1503,
                            Descricao = "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci",
                            Localizacao = "Museu lo Louvre",
                            Titulo = "Monalisa"
                        },
                        new
                        {
                            Id = 5,
                            Artista = "Leonardo da Vinci",
                            Categoria = "Pintura",
                            Data = 1503,
                            Descricao = "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci",
                            Localizacao = "Museu lo Louvre",
                            Titulo = "Monalisa"
                        },
                        new
                        {
                            Id = 6,
                            Artista = "Leonardo da Vinci",
                            Categoria = "Pintura",
                            Data = 1503,
                            Descricao = "Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci",
                            Localizacao = "Museu lo Louvre",
                            Titulo = "Monalisa"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
