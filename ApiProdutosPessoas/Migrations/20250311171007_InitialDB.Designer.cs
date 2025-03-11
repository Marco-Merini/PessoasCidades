﻿// <auto-generated />
using ApiProdutosPessoas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiPessoasDependentesTest.Migrations
{
    [DbContext(typeof(TESTEAPIPESSOASDEPENDENTES))]
    [Migration("20250311171007_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ApiProdutosPessoas.Models.CidadeModel", b =>
                {
                    b.Property<int>("CodigoIBGE")
                        .HasColumnType("int");

                    b.Property<int>("CodigoPais")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("CodigoIBGE");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("ApiProdutosPessoas.Models.DependenteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CodigoDependente")
                        .HasColumnType("int");

                    b.Property<int>("CodigoPessoa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodigoDependente");

                    b.HasIndex("CodigoPessoa");

                    b.ToTable("Dependentes");
                });

            modelBuilder.Entity("ApiProdutosPessoas.Models.PessoaModel", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int>("CodigoIBGE")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NumeroEstabelecimento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoIBGE");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ApiProdutosPessoas.Models.DependenteModel", b =>
                {
                    b.HasOne("ApiProdutosPessoas.Models.PessoaModel", "Dependente")
                        .WithMany()
                        .HasForeignKey("CodigoDependente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ApiProdutosPessoas.Models.PessoaModel", "Pessoa")
                        .WithMany("Dependentes")
                        .HasForeignKey("CodigoPessoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dependente");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ApiProdutosPessoas.Models.PessoaModel", b =>
                {
                    b.HasOne("ApiProdutosPessoas.Models.CidadeModel", "Cidade")
                        .WithMany()
                        .HasForeignKey("CodigoIBGE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ApiProdutosPessoas.Models.PessoaModel", b =>
                {
                    b.Navigation("Dependentes");
                });
#pragma warning restore 612, 618
        }
    }
}
