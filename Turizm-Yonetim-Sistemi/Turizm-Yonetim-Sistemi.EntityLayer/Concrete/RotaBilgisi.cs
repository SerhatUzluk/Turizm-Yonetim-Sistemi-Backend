using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class RotaBilgisi : IEntity
    {
        public int RotaID { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        List<Terminal> Terminaller { get; set; }
    }
}
