using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs
{
    public class RotaDTO
    {
        [Key]
        [Required]
        public int RotaID { get; set; }
        [Required]
        public string KalkisYeri { get; set; }
        [Required]
        public string VarisYeri { get; set; }
    }
}
