using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class Pengguna
    {
        public Pengguna()
        {
            this.TenantPengguna = new List<TenantPengguna>();
        }

        [Key]
        public string Username { get; set; }
        //di isi jika hanya pasien
        public string IdPasien { get; set; }
        public string Nama { get; set; }
        public string Gender { get; set; }
        public short Umur { get; set; }
        public string Alamat { get; set; }
        public string Kota { get; set; }
        public string NoTelpon { get; set; }
        public string NoHP { get; set; }
        //all user
        public string Email { get; set; }
        public double Prosentase { get; set; }
        public string rolename { get; set; }
        //current role di masukan tempdata untuk mengetahui role lama dari user
        public string currentrole { get; set; }
        public string TenantID { get; set; }
        //for test using checkbox if i had 2 user or more....

        public Tenant Tenant { get; set; }
        public DetailPasien DetailPasien { get; set; }
        public IEnumerable<TenantPengguna> TenantPengguna { get; set; }
        public bool IsEnabled { get; set; }
        public bool Status { get; set; }
    }
}
