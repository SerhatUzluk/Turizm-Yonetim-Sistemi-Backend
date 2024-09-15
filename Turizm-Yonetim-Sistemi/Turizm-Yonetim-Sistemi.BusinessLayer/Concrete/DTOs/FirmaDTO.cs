using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs
{
    internal class FirmaDTO
    {
        [Key]
        [Required]
        public int FirmaID { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string MailAdres { get; set; }
        [Required]
        public string TelefonNumarasi { get; set; }
        [Required]
        public string FirmaAdi { get; set; }
    }
}
