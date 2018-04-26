using Microsoft.EntityFrameworkCore;
using PatchesToneLib.Application.Interfaces;
using PatchesToneLib.Domain.Patches;
using PatchesToneLib.Persistance.Patches;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatchesToneLib.Persistance
{
  public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<Patch> Patches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source="+AppDomain.CurrentDomain.BaseDirectory+"patches.db");
        }


        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PatchConfiguration());

        }
    }
}