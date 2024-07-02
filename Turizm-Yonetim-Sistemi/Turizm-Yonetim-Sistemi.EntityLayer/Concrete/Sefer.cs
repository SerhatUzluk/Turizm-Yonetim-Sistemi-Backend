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
    public class Sefer : IEntity
    {
        [Key]
        [Required]
        public int SeferID { get; set; }
        [Required]
        public int TasitID { get; set; }
        [InverseProperty("Bilet")]
        List<Bilet> Biletler { get; set; }
        [InverseProperty("Personel")]
        List<Personel> SeferPersonelleri { get; set; }        
        
        [ForeignKey("TasitID")]
        public Tasit Tasit { get; set; }
        [Required]
        public DateTime KalkisZamani { get; set; }
        [Required]
        public DateTime VarisZamani { get; set; }
        [Required]
        public int FirmaID { get; set; }
        [Required]
        public decimal BiletSatisFiyati { get; set; }
        [Required]
        public int RotaID { get; set; }
        [ForeignKey("RotaBilgisiID")]
        public RotaBilgisi Rota { get; set; }

    }

}
