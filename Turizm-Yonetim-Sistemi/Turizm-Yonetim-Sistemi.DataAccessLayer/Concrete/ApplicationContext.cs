using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turizm_Yonetim_Sistemi.EntityLayer.Concrete;

namespace Turizm_Yonetim_Sistemi.DataAccessLayer.Concrete
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<FirmaGorevlisi> FirmaGorevlileri { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole<string>>().HasData(
                new IdentityRole<string> { Id = Guid.NewGuid().ToString(), Name = "Planlama", NormalizedName = "PLANLAMA" },
                new IdentityRole<string> { Id = Guid.NewGuid().ToString(), Name = "Satis", NormalizedName = "SATIS" },
                new IdentityRole<string> { Id = Guid.NewGuid().ToString(), Name = "Yonetici", NormalizedName = "YONETICI" },
                new IdentityRole<string> { Id = Guid.NewGuid().ToString(), Name = "Kullanici", NormalizedName = "KULLANICI" }
        );
        }
    }
}
