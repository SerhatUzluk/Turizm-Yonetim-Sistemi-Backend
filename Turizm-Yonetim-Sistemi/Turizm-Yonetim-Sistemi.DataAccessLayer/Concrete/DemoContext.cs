using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Concrete
{
    public class DemoContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1LN2A4D;Initial Catalog=Turizm-Yonetim-Db;Integrated Security=True;Trust Server Certificate=True");
        }

        public DbSet<Bilet> Bilets { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<FirmaGorevlisi> Gorevlis { get; set; }
        public DbSet<Kampanya> Kampanyas { get; set; }        
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<RotaBilgisi> RotaBilgisis { get; set; }
        public DbSet<Sefer> Sefers { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Tasit> Tasits { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Vardiya> Vardiyas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>()
           .Property(p => p.Maas)
           .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sefer>()
                .Property(s => s.BiletSatisFiyati)
                .HasColumnType("decimal(18,2)");
        }
    }
}
