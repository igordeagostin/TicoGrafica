﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicoGrafica.Infrastructure;

namespace TicoGrafica.Infrastructure.Migrations
{
    [DbContext(typeof(TicoGraficaContext))]
    [Migration("20211021235058_InclusaoDeUnidadeDeMedida")]
    partial class InclusaoDeUnidadeDeMedida
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("TicoGrafica.Model.Modelos.ContasAPagar.ContasPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataDeVencimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Situacao")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("ContasPagar");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.ContasAReceber.ContasReceber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataDeVencimento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataDoPedido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Situacao")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("ContasReceber");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Orcamentos.Orcamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("FormaDePagamento")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.HasIndex("IdProduto");

                    b.ToTable("Orcamento");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Pessoas.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celular")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Produtos.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnidadeDeMedida")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.ContasAPagar.ContasPagar", b =>
                {
                    b.HasOne("TicoGrafica.Model.Modelos.Pessoas.Pessoa", "Pessoa")
                        .WithMany("ContasAPagar")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.ContasAReceber.ContasReceber", b =>
                {
                    b.HasOne("TicoGrafica.Model.Modelos.Pessoas.Pessoa", "Pessoa")
                        .WithMany("ContasAReceber")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Orcamentos.Orcamento", b =>
                {
                    b.HasOne("TicoGrafica.Model.Modelos.Pessoas.Pessoa", "Pessoa")
                        .WithMany("Orcamentos")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TicoGrafica.Model.Modelos.Produtos.Produto", "Produto")
                        .WithMany("Orcamentos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pessoa");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Pessoas.Pessoa", b =>
                {
                    b.OwnsOne("TicoGrafica.Model.Modelos.Pessoas.EnderecoPessoa", "Endereco", b1 =>
                        {
                            b1.Property<int>("PessoaId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Bairro")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Cep")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Complemento")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Endereco")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Municipio")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Numero")
                                .HasColumnType("TEXT");

                            b1.HasKey("PessoaId");

                            b1.ToTable("EnderecoPessoa");

                            b1.WithOwner("Pessoa")
                                .HasForeignKey("PessoaId");

                            b1.Navigation("Pessoa");
                        });

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Pessoas.Pessoa", b =>
                {
                    b.Navigation("ContasAPagar");

                    b.Navigation("ContasAReceber");

                    b.Navigation("Orcamentos");
                });

            modelBuilder.Entity("TicoGrafica.Model.Modelos.Produtos.Produto", b =>
                {
                    b.Navigation("Orcamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
