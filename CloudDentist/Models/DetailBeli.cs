using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class DetailBeli
    {
        [Key]
        public string DetailBeliId { get; set; }
        public int IdBeli { get; set; }
        public DateTime Tanggal { get; set; } = System.DateTime.Today;
        public int IdBarang { get; set; }
        public short Qty { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int Harga { get; set; }
        public int totalharga { get; set; }
        public Barang Barang { get; set; }
        public Beli beli { get; set; }
    }
}
