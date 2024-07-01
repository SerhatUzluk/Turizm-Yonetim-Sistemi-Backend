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
    public class RotaBilgisi : IEntity
    {
        [Key]
        [Required]
        public int RotaID { get; set; }
        [Required]
        public string KalkisYeri { get; set; }
        [Required]
        public string VarisYeri { get; set; }
        [InverseProperty("Terminal")]
        List<Terminal> Terminaller { get; set; }
    }
}
