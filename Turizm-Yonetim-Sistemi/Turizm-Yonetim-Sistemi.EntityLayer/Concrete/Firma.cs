using Core.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.EntityLayer.Concrete
{
    public class Firma : IEntity
    {
        public int FirmaID { get; set; }
        public string Adres { get; set; }
        public string MailAdres { get; set; }
        public string TelefonNumarasi { get; set; }
        public string FirmaAdi { get; set; }
        List<Sofor> Soforler { get; set; }
        List<Muavin> Muavinler { get; set; }
        List<Kampanya> Kampanyalar { get; set; }
        List<Tasit> Tasitlar { get; set; }
    }
}
