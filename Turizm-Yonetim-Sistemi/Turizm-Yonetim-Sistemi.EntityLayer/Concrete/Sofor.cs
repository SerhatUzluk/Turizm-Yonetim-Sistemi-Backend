using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Sofor : IStaff, IEntity
    {
        [Key]
        [Required]
        public int PersonelID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public int Puan { get; set; }
        [Required]
        public decimal Maas { get; set; }
        [Required]
        public int Yas { get; set; }
        [Required]
        public string PersonelTipi { get; set; }
        [InverseProperty("Vardiya")]
        List<Vardiya> vardiyaListesi { get; set; }
    }
}
