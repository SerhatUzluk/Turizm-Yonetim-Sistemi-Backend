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
    public class FirmaGorevlisi : IUser, IEntity
    {
        [Key]
        [Required]
        public int KullaniciID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string MailAdres { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public int RoleID { get; set; }
        [Required]
        public string TelefonNumarasi { get; set; }
        [Required]
        public int FirmaID { get; set; }
        [ForeignKey("FirmaID")]
        public Firma firma { get; set; }
        [Required]
        public string Unvan { get; set; }
    }

}
