using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Bilet : IEntity
    {
        public int BiletID { get; set; }
        public int MusteriID { get; set; }
        public int KoltukNo { get; set; }
        public int SeferID { get; set; }
    }
}
