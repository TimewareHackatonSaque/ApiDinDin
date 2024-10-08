﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi.Infraestrutura;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(Conexao))]
    partial class ConexaoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Model.Cotacoes", b =>
                {
                    b.Property<int>("idCotacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idCotacao"));

                    b.Property<int>("idUsuario")
                        .HasColumnType("integer");

                    b.Property<int>("parcelas")
                        .HasColumnType("integer");

                    b.Property<double>("valor")
                        .HasColumnType("double precision");

                    b.HasKey("idCotacao");

                    b.ToTable("cotacoes");
                });

            modelBuilder.Entity("WebApi.Model.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idUsuario");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
