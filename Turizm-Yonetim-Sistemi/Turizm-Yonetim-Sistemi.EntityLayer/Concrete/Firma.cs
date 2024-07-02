using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Firma : IEntity
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
        [InverseProperty("Personel")]
        List<Personel> Personeller { get; set; }                
        [InverseProperty("Kampanya")]
        List<Kampanya> Kampanyalar { get; set; }
        [InverseProperty("Tasit")]
        List<Tasit> Tasitlar { get; set; }
        [InverseProperty("Sefer")]
        List<Sefer> Seferler { get; set; }
    }
}
