using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Barang
    {
        public Barang()
        {
            this.Beli = new List<Beli>();
            this.Jual = new List<Jual>();
        }

        [Key]
        public int IdBarang { get; set; }
        public string NamaBarang { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int Harga { get; set; }
        public short Stok { get; set; }
        // Di sort sesuai dengan KatBarang yang ada di tenant yang di pilih oleh user
        // Data Tenant di ambil stelah verifikasi dengan Pengguna 
        public int IdKatBarang { get; set; }
        public string Keterangan { get; set; }
        public int Minstok { get; set; }

        public KatBarang KatBarang { get; set; }
        public List<Beli> Beli { get; set; }
        public List<Jual> Jual { get; set; }
    }
}
