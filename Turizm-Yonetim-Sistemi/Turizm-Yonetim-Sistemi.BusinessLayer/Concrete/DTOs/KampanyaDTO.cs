using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs
{
    public class KampanyaDTO
    {
        [Key]
        [Required]
        public int KampanyaID { get; set; }
        [Required]
        public string Tanim { get; set; }
        [Required]
        public int FirmaID { get; set; }
    }
}
