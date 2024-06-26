using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public interface IStaff
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Puan { get; set; }
        public decimal Maas { get; set; }
        public int Yas { get; set; }
        public string PersonelTipi { get; set; }
    }
}
