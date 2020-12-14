using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CloudDentist.Models
{
    public class JenisTindakan
    {
        public JenisTindakan()
        {
            this.Prosentase = new List<Prosentase>();
            this.Tindakan = new List<Tindakan>();
        }
        [Key]
        public int IdJenisTindakan { get; set; }
        public int IdKatJenis { get; set; }
        //jenis nama tindakan 
        public string Jenis { get; set; }
        //lait di database
        public int Biaya { get; set; }
        //sengaja contoh sebagai contoh     
        public string Keterangan { get; set; }
        public string TenantID { get; set; }
        public string PilihJenis { get; set; }
        public Tenant Tenant { get; set; }
        public KatJenis KatJenis { get; set; }
        public IEnumerable<Prosentase> Prosentase { get; set; }
        public IEnumerable<Tindakan> Tindakan { get; set; }
        
    }
}