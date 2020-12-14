using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class KatBarang
    {
        public KatBarang()
        {
            this.Barang = new List<Barang>();
        }
        [Key]
        public int IdKategori { get; set; }
        [Required(ErrorMessage = "{0}  jangan lupa harus di isi")]
        [Display(Prompt = "Nama Kategori harus di isi...")]
        public string NamaKategori { get; set; }
        [Required(ErrorMessage = "{0}  jangan lupa harus di isi")]
        [Display(Prompt = "Tenant ID harus di isi...")]
        public string TenantID { get; set; }

        public List<Barang> Barang { get; set; }
        public Tenant Tenant { get; set; }
    }
}
