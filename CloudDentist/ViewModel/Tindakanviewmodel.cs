using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Tindakanviewmodel
    {
        public int IdTindakan { get; set; }
        public int IdTransaksi { get; set; }
        //posisi gigi menggunakan KUADRAN GIGI 

        public int IdJenisTindakan { get; set; }
        //biaya dokter ? dan klinik yes 
        public int Biaya { get; set; }
        //persenan ini apa ? yang akan didapat ketika ada transaksi ? 
        public int Persenan { get; set; }
        public string Diagnosis { get; set; }
        //beda dengan yang di jenis tindakan apa ? 
        public int BiayaDasar { get; set; }
        //apakah ini berdasarkan jumlah posisi x deengan biaya dasar
        public int BiayaKelipatan { get; set; }
        //status perbedaan dengan gigi palsu apa ? 
        public string Status { get; set; }
        public string TenantID { get; set; }

        public Tenant Tenant { get; set; }
        public List<pilihGigi> Posisi { get; set; }
        public Transaksi Transaksi { get; set; }
        public JenisTindakan JenisTindakan { get; set; }

        public List<checkBoxItem> GigiRawat { get; set; }

    }
}
