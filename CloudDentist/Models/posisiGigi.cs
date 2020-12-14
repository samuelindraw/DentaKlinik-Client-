using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class posisiGigi
    {
        public string id { get; set; }
        public int gigiPosisi { get; set; }
        public string kuadran { get; set; }

        public List<pilihGigi> Posisi { get; set; }
    }
}
