using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Kampanya : IEntity
    {
        public int KampanyaID { get; set; }
        public string Tanim { get; set; }
        public int FirmaID { get; set; }
    }
}
