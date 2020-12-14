using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Prosentase
    {

        [Key]
        public int IdProsentase { get; set; }
        public string Username { get; set; }
        //public string DetailPegawaiID { get; set; }
        public int IdJenisTindakan { get; set; }
        public float Prosen { get; set; }
        public string TenantID { get; set; }

        public Tenant Tenant { get; set; }
        public Pengguna Pengguna { get; set; }
        public KatJenis KatJenis { get; set; }
        public JenisTindakan JenisTindakan { get; set; }
    }
}
