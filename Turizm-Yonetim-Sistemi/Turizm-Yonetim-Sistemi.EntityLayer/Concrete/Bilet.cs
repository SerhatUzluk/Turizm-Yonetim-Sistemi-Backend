using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Bilet : IEntity
    {
        [Key]
        [Required]
        public int BiletID { get; set; }
        [Required]
        public int MusteriID { get; set; }
        [ForeignKey("MusteriID")]
        public Musteri musteri { get; set; }
        [Required]
        public int KoltukNo { get; set; }
        [Required]        
        public int SeferID { get; set; }
        [ForeignKey("SeferID")]
        public Sefer sefer { get; set; }        
    }
}
