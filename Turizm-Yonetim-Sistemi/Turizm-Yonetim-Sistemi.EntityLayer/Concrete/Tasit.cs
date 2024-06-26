using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Tasit : IEntity
    {
        public int TasitID { get; set; }
        public int Kapasite { get; set; }
        public string Plaka { get; set; }
        public bool KullanimDurumu { get; set; }
        public int FirmaID { get; set; }
        public string TasitTuru { get; set; }
        List<Sofor> Soforler { get; set; }
        List<Muavin> Muavinler { get; set; }
    }
}
