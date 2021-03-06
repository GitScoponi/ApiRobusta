﻿// <auto-generated />
using System;
using ApiRobusta.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiRobusta.Infra.Migrations
{
    [DbContext(typeof(ApiRobustaContext))]
    [Migration("20200629162916_Criar Tabelas")]
    partial class CriarTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiRobustaCurso.Entities.Campanha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<Guid?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Campanha");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Contato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Nicho");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.Property<Guid?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Envio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CampanhaId");

                    b.Property<Guid?>("ContatoId");

                    b.Property<bool>("Enviado");

                    b.Property<Guid?>("GrupoId");

                    b.HasKey("Id");

                    b.HasIndex("CampanhaId");

                    b.HasIndex("ContatoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("Envio");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Grupo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Nicho");

                    b.Property<string>("Nome");

                    b.Property<Guid?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Campanha", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Contato", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Envio", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Campanha", "Campanha")
                        .WithMany()
                        .HasForeignKey("CampanhaId");

                    b.HasOne("ApiRobustaCurso.Entities.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoId");

                    b.HasOne("ApiRobustaCurso.Entities.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Grupo", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
