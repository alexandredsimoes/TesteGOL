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
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnectionSql"))
                    .EnableSensitiveDataLogging(true);
        }
    }
}
