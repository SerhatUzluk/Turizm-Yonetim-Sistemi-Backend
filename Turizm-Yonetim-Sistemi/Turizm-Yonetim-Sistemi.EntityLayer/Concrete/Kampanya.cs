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
    public class Kampanya : IEntity
    {
        [Key]
        [Required]
        public int KampanyaID { get; set; }
        [Required]
        public string Tanim { get; set; }
        [Required]
        public int FirmaID { get; set; }
        [ForeignKey("FirmaID")]
        public Firma firma { get; set; }
    }
}
