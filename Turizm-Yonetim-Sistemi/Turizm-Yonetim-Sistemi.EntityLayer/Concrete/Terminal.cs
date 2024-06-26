using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Terminal : IEntity
    {
        public int TerminalID { get; set; }
        public string Sehir { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string TerminalAdi { get; set; }
    }
}
