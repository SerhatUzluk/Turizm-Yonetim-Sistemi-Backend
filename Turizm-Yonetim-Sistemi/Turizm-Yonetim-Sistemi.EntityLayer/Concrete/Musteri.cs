using Core.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Musteri : IdentityUser<string>, IUser, IEntity
    {
        [Key]
        [Required]
        public int KullaniciID { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }        
        [Required]
        public string Sifre { get; set; }        
        [Required]
        public string TelefonNumarasi { get; set; }
        [Required]
        public string Cinsiyet { get; set; }
        [Required]
        public string KimlikNo { get; set; }
    }
}
