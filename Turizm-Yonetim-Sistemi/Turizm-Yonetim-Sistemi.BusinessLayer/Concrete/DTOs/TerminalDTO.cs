using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turizm_Yonetim_Sistemi.BusinessLayer.Concrete.DTOs
{
    internal class TerminalDTO
    {
        [Key]
        [Required]
        public int TerminalID { get; set; }
        [Required]
        public string Sehir { get; set; }
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Long { get; set; }
        [Required]
        public string TerminalAdi { get; set; }
    }
}
