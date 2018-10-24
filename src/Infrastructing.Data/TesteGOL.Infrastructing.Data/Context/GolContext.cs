using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TesteGOL.Domain.Cadastros.Entidades;
using System;
using System.IO;

namespace TesteGOL.Infrastructing.Data.Context
{
    public class GolContext : DbContext
    {
        public DbSet<Airplane> Estados { get; set; }

        public GolContext() : base()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airplane>()
                .ToTable("Airplane");

            modelBuilder.Entity<Airplane>()
                .Property(c => c.CodigoAviao)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<Airplane>()
                .Property(c => c.DataRegistro)
                .IsRequired();

            modelBuilder.Entity<Airplane>()
                .Property(c => c.Modelo)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Airplane>()
                .Property(c => c.Passageiros)
                .IsRequired();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnectionSql"))
                    .EnableSensitiveDataLogging(true);
        }             
    }
}
