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
        public DbSet<Muavin> Muavins { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<RotaBilgisi> RotaBilgisis { get; set; }
        public DbSet<Sefer> Sefers { get; set; }
        public DbSet<Sofor> Sofors { get; set; }
        public DbSet<Tasit> Tasits { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Vardiya> Vardiyas { get; set; }


    }
}
