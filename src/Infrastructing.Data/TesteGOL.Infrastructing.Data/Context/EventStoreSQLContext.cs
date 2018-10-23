using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TesteGOL.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteGOL.Infrastructing.Data.Context
{
    public class EventStoreSQLContext : DbContext
    {
        public DbSet<StoredEvent> StoredEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.AddConfiguration(new StoredEventMap());

            base.OnModelCreating(modelBuilder);
        }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = ConfigurationServices.GetConfiguration();

            string client = config["Database:Client"]?.ToLowerInvariant();

            if (client == "firebird")
            {
                optionsBuilder.UseFirebird(config.GetConnectionString("DefaultConnectionFirebird").Replace("{PATH}", ConfigurationServices.GetCurrentDirectory()))
                    .EnableSensitiveDataLogging(true);
            }
            else if (client == "mysql")
            {
                optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnectionMySql").Replace("{PATH}", ConfigurationServices.GetCurrentDirectory()))
                    .EnableSensitiveDataLogging(true);
            }
            else if (client == null || client == "sqlserver")
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnectionSql"))
                    .EnableSensitiveDataLogging(true);
            }
        }
    }
}
