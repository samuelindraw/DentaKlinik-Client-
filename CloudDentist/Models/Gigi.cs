using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Gigi
    {
        [Key]
        public int idGigi { get; set; }
        public string Kuadran { get; set; }
        public int nomerPosisi { get; set; }
    }
}
