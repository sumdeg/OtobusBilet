using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class BiletSistemDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BiletSistemDB;Trusted_Connection=true");
        }
 
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Sefer> Seferler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
    
    }

}
