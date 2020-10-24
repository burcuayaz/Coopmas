using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coopmas.Models
{
    public class Hizmetler
    {
        [Key]
        public int id { get; set; }
        public string HizmetAdi { get; set; }
        public string Ozellik { get; set; }
        public int Fiyat { get; set; }
        public string Dokumantasyon { get; set; }
        public int Satisİletisim { get; set; }


    }
}
