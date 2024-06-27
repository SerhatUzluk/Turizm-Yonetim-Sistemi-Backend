using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Vardiya: IEntity
    {
        public int VardiyaID { get; set; }
        public DateTime PztBaslangic { get; set; }
        public DateTime PztBitis { get; set; }
        public DateTime SaliBaslangic { get; set; }
        public DateTime SaliBitis { get; set; }
        public DateTime CrsBaslangic { get; set; }
        public DateTime CrsBitis { get; set; }
        public DateTime PrsBaslangic { get; set; }
        public DateTime PrsBitis { get; set; }
        public DateTime CumBaslangic { get; set; }
        public DateTime CumBitis { get; set; }
        public DateTime CmtBaslangic { get; set; }
        public DateTime CmtBitis { get; set; }
        public DateTime PzrBaslangic { get; set; }
        public DateTime PzrBitis { get; set; }
        public DateTime VardiyaBaslangicTarihi { get; set; }
        public DateTime VardiyaBitisTarihi { get; set; }


    }

}
