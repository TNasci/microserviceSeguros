﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using microserviceSeguros.Infrastruture.Data;

#nullable disable

namespace microserviceSeguros.Infrastruture.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20230213141853_FirstMigrate")]
    partial class FirstMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("microserviceSeguros.Domain.Entities.Apolice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_alteracao_registro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_criacao_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("premio_total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usuario_alteracao_registro")
                        .HasColumnType("int");

                    b.Property<int>("usuario_criacao_registro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Apolice");
                });

            modelBuilder.Entity("microserviceSeguros.Domain.Entities.Parcela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("apoliceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_alteracao_registro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_criacao_registro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_pagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_pago")
                        .HasColumnType("datetime2");

                    b.Property<string>("forma_pagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("juros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("premio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("situacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usuario_alteracao_registro")
                        .HasColumnType("int");

                    b.Property<int>("usuario_criacao_registro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("apoliceId");

                    b.ToTable("Parcelas");
                });

            modelBuilder.Entity("microserviceSeguros.Domain.Entities.Parcela", b =>
                {
                    b.HasOne("microserviceSeguros.Domain.Entities.Apolice", "apolice")
                        .WithMany("parcelas")
                        .HasForeignKey("apoliceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apolice");
                });

            modelBuilder.Entity("microserviceSeguros.Domain.Entities.Apolice", b =>
                {
                    b.Navigation("parcelas");
                });
#pragma warning restore 612, 618
        }
    }
}