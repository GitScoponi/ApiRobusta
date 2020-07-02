﻿// <auto-generated />
using System;
using ApiRobusta.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiRobusta.Infra.Migrations
{
    [DbContext(typeof(ApiRobustaContext))]
    partial class ApiRobustaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<Guid?>("IdUsuario");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Campanha");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Contato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("IdUsuario");

                    b.Property<int>("Nicho");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Envio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Enviado");

                    b.Property<Guid?>("IdCampanha");

                    b.Property<Guid?>("IdContato");

                    b.Property<Guid?>("IdGrupo");

                    b.HasKey("Id");

                    b.HasIndex("IdCampanha");

                    b.HasIndex("IdContato");

                    b.HasIndex("IdGrupo");

                    b.ToTable("Envio");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Grupo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("IdUsuario");

                    b.Property<int>("Nicho");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

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
                        .HasForeignKey("IdUsuario");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Contato", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Envio", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Campanha", "Campanha")
                        .WithMany()
                        .HasForeignKey("IdCampanha");

                    b.HasOne("ApiRobustaCurso.Entities.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("IdContato");

                    b.HasOne("ApiRobustaCurso.Entities.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("IdGrupo");
                });

            modelBuilder.Entity("ApiRobustaCurso.Entities.Grupo", b =>
                {
                    b.HasOne("ApiRobustaCurso.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
