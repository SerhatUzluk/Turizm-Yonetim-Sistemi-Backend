using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Sofor : IStaff, IEntity
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Puan { get; set; }
        public decimal Maas { get; set; }
        public int Yas { get; set; }
        public string PersonelTipi { get; set; }
        List<Vardiya> vardiyaListesi { get; set; }
    }
}
