using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Tindakan
    {
        [Key]
        public int IdTindakan { get; set; }
        public int IdTransaksi { get; set; }
        //posisi gigi menggunakan KUADRAN GIGI 

        public int IdJenisTindakan { get; set; }
        //biaya dokter ? dan klinik yes 
        public int biaya { get; set; }
        //persenan ini apa ? yang akan didapat ketika ada transaksi ? 
        public int Persenan { get; set; }
        public string Diagnosis { get; set; }
        //beda dengan yang di jenis tindakan apa ? 
        public int BiayaDasar { get; set; }
        //apakah ini berdasarkan jumlah posisi x deengan biaya dasar
        public string Status { get; set; }
        public string TenantID { get; set; }

        public Tenant Tenant { get; set; }
        public List<pilihGigi> Posisi { get; set; }
        public Transaksi Transaksi { get; set; }
        public JenisTindakan JenisTindakan { get; set; }
        public checkBoxItem checkBoxItem { get; set; }
        public List<checkBoxItem> GigiRawat { get; set; }
        public List<checkBoxItem> GigiRawatK1 { get; set; }
        public List<checkBoxItem> GigiRawatK2 { get; set; }
        public List<checkBoxItem> GigiRawatK3 { get; set; }
        public List<checkBoxItem> GigiRawatK4 { get; set; }
        public List<checkBoxItem> GigiRawatKI { get; set; }
        public List<checkBoxItem> GigiRawatKII { get; set; }
        public List<checkBoxItem> GigiRawatKIII { get; set; }
        public List<checkBoxItem> GigiRawatKIV { get; set; }

    }
}
