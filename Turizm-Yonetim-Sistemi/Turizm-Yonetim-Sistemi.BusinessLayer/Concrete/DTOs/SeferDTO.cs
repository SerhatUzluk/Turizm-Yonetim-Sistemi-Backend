using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs
{
    public class SeferDTO
    {
        public int SeferID { get; set; }
        public int TasitID { get; set; }
        public DateTime KalkisZamani { get; set; }
        public DateTime VarisZamani { get; set; }
        public int FirmaID { get; set; }
        public decimal BiletSatisFiyati { get; set; }
        public int RotaID
        {
            get; set;
        }
    }
}
