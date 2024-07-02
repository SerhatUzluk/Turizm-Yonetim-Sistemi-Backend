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
    public class Tasit : IEntity
    {
        [Key]
        [Required]
        public int TasitID { get; set; }
        [Required]
        public int Kapasite { get; set; }
        [Required]
        public string Plaka { get; set; }
        [Required]
        public bool KullanimDurumu { get; set; }
        [Required]
        public int FirmaID { get; set; }
        [ForeignKey("FirmaID")]
        public Firma firma { get; set; }
        [Required]
        public string TasitTuru { get; set; }       
    }
}
