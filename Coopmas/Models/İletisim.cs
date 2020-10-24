using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coopmas.Models
{
    public class İletisim
    {
        [Key]
        public int id { get; set; }
        public string adsoyad { get; set; }
        public string eposta { get; set; }
        public string konu { get; set; }
        
        public string mesaj { get; set; }
    }
}
