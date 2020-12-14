using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Beli
    {
        // kalau stok barang habis munculkan notif ke perawat/admin ada stok yang mau habis ? < 3
        [Key]
        public int IdBeli { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Tanggal { get; set; }
        public string NamaPembelian { get; set; }
        public string Keterangan { get; set; }
        public string TenantID { get; set; }
        public int TotalHarga { get; set; }
        public Tenant Tenant { get; set; }
    }
}
