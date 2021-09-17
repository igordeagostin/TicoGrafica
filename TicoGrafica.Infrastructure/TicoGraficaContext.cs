using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TicoGrafica.Model.Modelos.ContasAPagar;
using TicoGrafica.Model.Modelos.ContasAReceber;
using TicoGrafica.Model.Modelos.Orcamentos;
using TicoGrafica.Model.Modelos.Pessoas;
using TicoGrafica.Model.Modelos.Produtos;

namespace TicoGrafica.Infrastructure
{
    public class TicoGraficaContext : DbContext
    {
        public TicoGraficaContext() { }
        public TicoGraficaContext(DbContextOptions<TicoGraficaContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<EnderecoPessoa> EnderecoPessoa { get; set; }
        public DbSet<ContasPagar> ContasPagar { get; set; }
        public DbSet<ContasReceber> ContasReceber { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddXmlFile("App.config")
                    .Build();

                string connectionString;
                configuration
                    .Providers
                    .FirstOrDefault()
                    .TryGet("connectionStrings:add:ConnectionString:connectionString", out connectionString);

                optionsBuilder.UseSqlite(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Pessoa
            builder.Entity<Pessoa>().HasKey(m => m.Id);
            builder.Entity<Pessoa>().OwnsOne(p => p.Endereco);

            ////Produto
            //builder.Entity<EnderecoPessoa>().HasKey(m => m.IdPessoa);

            //Produto
            builder.Entity<Produto>().HasKey(m => m.Id);

            //Orçamento
            builder.Entity<Orcamento>().HasKey(m => m.Id);
            builder.Entity<Orcamento>().HasOne(x => x.Pessoa)
                .WithMany(x => x.Orcamentos)
                .HasForeignKey(x => x.IdPessoa)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Orcamento>().HasOne(x => x.Produto)
                .WithMany(x => x.Orcamentos)
                .HasForeignKey(x => x.IdProduto)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            //Contas a receber
            builder.Entity<ContasReceber>().HasKey(m => m.Id);
            builder.Entity<ContasReceber>().HasOne(x => x.Pessoa)
                .WithMany(x => x.ContasAReceber)
                .HasForeignKey(x => x.IdPessoa)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            //Contas a pagar
            builder.Entity<ContasPagar>().HasKey(m => m.Id);
            builder.Entity<ContasPagar>().HasOne(x => x.Pessoa)
                .WithMany(x => x.ContasAPagar)
                .HasForeignKey(x => x.IdPessoa)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
