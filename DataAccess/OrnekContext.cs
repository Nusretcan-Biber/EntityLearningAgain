﻿using Data;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DataAccess
{
    public class OrnekContext :DbContext
    {
        public DbSet<OrnekTablo> OrnekTablos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         //   modelBuilder.Entity<OrnekTablo>().ToTable(nameof(OrnekTablo));
            modelBuilder.Entity<OrnekTablo>().HasKey(x => x.PersonId);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Program Files\\DB Browser for SQLite\\EntityLearning.db;");
            //Environment.GetEnvironmentVariable("SQLITE_URI")
        }

    }
}