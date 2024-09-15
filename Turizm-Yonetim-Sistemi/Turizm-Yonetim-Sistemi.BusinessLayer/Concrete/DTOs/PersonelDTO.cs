using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs
{
    public class PersonelDTO
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
    }
}
