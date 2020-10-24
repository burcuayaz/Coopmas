using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coopmas.Models
{
    public class talep
    {
        [Key]
        public int id { get; set; }
        public string soru1 { get; set; }
        public DateTime soru2 { get; set; }
        public string soru3 { get; set; }

        public int soru4 { get; set; }
        public string email { get; set; }
        public int telephone { get; set; }
        public string name { get; set; }

    }
}
