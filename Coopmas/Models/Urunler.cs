using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Coopmas.Models;

namespace Coopmas.Models
{
    public class Urunler
    {
        [Key]
        public int ID { get; set; }
        public string AD { get; set; }
        public string Ozellik { get; set; }
        public int Fiyat { get; set; }
        public string Dokumantasyon { get; set; }
        public int Satisİletisim { get; set; }


    }
}
