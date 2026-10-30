using CegesAutoNyilvatartas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegesAutoNyilvatartas.Data
{
    public class AutoNyilvContext: DbContext
    {
        public DbSet<People> Peoples { get; set; }
        public DbSet<Auto> Autok { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AutoNyilv;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().ToTable("Auto");
        }
    }
}
