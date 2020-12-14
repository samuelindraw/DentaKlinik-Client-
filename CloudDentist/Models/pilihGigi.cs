using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class pilihGigi
    {
        public int IdTindakan { get; set; }
        public Tindakan Tindakan { get; set; }
        public string idposisiGigi { get; set; }
        public posisiGigi PosisiGigi { get; set; }
    }
}
