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
    public class Vardiya: IEntity
    {
        [Key]
        [Required]
        public int VardiyaID { get; set; }
        [Required]
        public DateTime PztBaslangic { get; set; }
        [Required]
        public DateTime PztBitis { get; set; }
        [Required]
        public DateTime SaliBaslangic { get; set; }
        [Required]
        public DateTime SaliBitis { get; set; }
        [Required]
        public DateTime CrsBaslangic { get; set; }
        [Required]
        public DateTime CrsBitis { get; set; }
        [Required]
        public DateTime PrsBaslangic { get; set; }
        [Required]
        public DateTime PrsBitis { get; set; }
        [Required]
        public DateTime CumBaslangic { get; set; }
        [Required]
        public DateTime CumBitis { get; set; }
        [Required]
        public DateTime CmtBaslangic { get; set; }
        [Required]
        public DateTime CmtBitis { get; set; }
        [Required]
        public DateTime PzrBaslangic { get; set; }
        [Required]
        public DateTime PzrBitis { get; set; }
        [Required]
        public DateTime VardiyaBaslangicTarihi { get; set; }
        [Required]
        public DateTime VardiyaBitisTarihi { get; set; }
        [Required]
        public int PersonelID { get; set; }
        [ForeignKey("PersonelID")]
        public IStaff Personel { get; set; }
    }

}
