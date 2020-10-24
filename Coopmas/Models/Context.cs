using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coopmas.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=AYAZ-LAPTOP; database=coopmas; integrated security=true;");
        }
        public DbSet<Urunler> urunlers { get; set; }
        public DbSet<Hizmetler> hizmetlers { get; set; }
        public DbSet<talep> taleps { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Admin> admins { get; set; }



    }
}
