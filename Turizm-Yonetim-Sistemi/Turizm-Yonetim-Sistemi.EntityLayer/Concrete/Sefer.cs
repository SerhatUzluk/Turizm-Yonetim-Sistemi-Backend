using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Sefer : IEntity
    {
        public int SeferID { get; set; }
        public int TasitID { get; set; }
        List<Bilet> Biletler { get; set; }
        List<Sofor> SeferSoforleri { get; set; }
        List<Muavin> SeferMuavinleri { get; set; }
        Tasit Tasit { get; set; }
        public DateTime KalkisZamani { get; set; }
        public DateTime VarisZamani { get; set; }
        public int FirmaID { get; set; }
        public decimal BiletSatisFiyati { get; set; }
        RotaBilgisi Rota { get; set; }

    }

}
