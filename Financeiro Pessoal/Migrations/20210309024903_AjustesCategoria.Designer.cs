﻿// <auto-generated />
using System;
using Financeiro_Pessoal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Financeiro_Pessoal.Migrations
{
    [DbContext(typeof(AppDb))]
    [Migration("20210309024903_AjustesCategoria")]
    partial class AjustesCategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Financeiro_Pessoal.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<int>("Tipo")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Financeiro_Pessoal.Models.Financeiro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<bool>("Despesa")
                        .HasColumnType("boolean");

                    b.Property<int?>("IndividuoID")
                        .HasColumnType("integer");

                    b.Property<string>("Observacoes")
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.Property<bool>("Recebido")
                        .HasColumnType("boolean");

                    b.Property<bool>("Receita")
                        .HasColumnType("boolean");

                    b.Property<int>("Sequencia")
                        .HasColumnType("integer");

                    b.Property<int>("SequenciaID")
                        .HasColumnType("integer");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("IndividuoID");

                    b.ToTable("Financeiro");
                });

            modelBuilder.Entity("Financeiro_Pessoal.Models.Individuo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Observacoes")
                        .HasColumnType("character varying(120)")
                        .HasMaxLength(120);

                    b.Property<string>("Telefone")
                        .HasColumnType("character varying(16)")
                        .HasMaxLength(16);

                    b.HasKey("ID");

                    b.ToTable("Individuos");
                });

            modelBuilder.Entity("Financeiro_Pessoal.Models.Financeiro", b =>
                {
                    b.HasOne("Financeiro_Pessoal.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Financeiro_Pessoal.Models.Individuo", "Individuo")
                        .WithMany()
                        .HasForeignKey("IndividuoID");
                });
#pragma warning restore 612, 618
        }
    }
}
