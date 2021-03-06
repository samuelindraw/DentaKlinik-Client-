﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Jual
    {
        // previous data transaksi yang di isi ? atau tindakan ? 
        [Key]
        public int IdJual { get; set; }
        public int IdBarang { get; set; }
        public int IdTransaksi { get; set; }
        public short Qty { get; set; }
        //dapet dari harga barang * qty ?
        public int Harga { get; set; }
        public string TenantID { get; set; }
        public Tenant Tenant { get; set; }
        public Barang Barang { get; set; }
        public Transaksi Transaksi { get; set; }
    }
}
