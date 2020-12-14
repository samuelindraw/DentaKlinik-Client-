using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class UserModel
    {
        [Key]
        public string Id;
        [Required(ErrorMessage = "{0}  jangan lupa harus di isi")]
        [Display(Name = "Username", Prompt = "Username yang kamu daftarkan...")]
        public string Username { get; set; }
        [Required(ErrorMessage = "{0}  jangan lupa harus di isi")]
        [Display(Name = "Nama", Prompt = "Nama yang kamu daftarkan...")]
        public string Nama { get; set; }
        [Required(ErrorMessage = "{0} harus di isi.")]
        [Display(Name = "Password", Prompt = "*******")]
        public string Password { get; set; }
        [Required(ErrorMessage = "{0} harus di isi.")]
        [Display(Name = "ConfirmPassword", Prompt = "*******")]
        [Compare("Password", ErrorMessage = "Password Anda Tidak Sesuai !")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "{0} Email harus di isi.")]
        [Display(Name = "Email", Prompt = "Email yang kamu daftarkan...")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} Alamat harus di isi.")]
        [Display(Name = "Alamat", Prompt = "Alamat yang kamu daftarkan...")]
        public string Alamat { get; set; }
        [Required(ErrorMessage = "{0} Kota harus di isi.")]
        [Display(Name = "Kota", Prompt = "Kota yang kamu daftarkan...")]
        public string Kota { get; set; }
        [Required(ErrorMessage = "{0} NoHp harus di isi.")]
        [Display(Name = "NoHp", Prompt = "NoHp yang kamu daftarkan...")]
        public string NoHp { get; set; }
        [Required(ErrorMessage = "{0} NoTelpon harus di isi.")]
        [Display(Name = "NoTelpon", Prompt = "NoTelpon yang kamu daftarkan...")]
        public string NoTelpon { get; set; }
        [Required(ErrorMessage = "{0} Prosentase harus di isi.")]
        [Display(Name = "Prosentase", Prompt = "Prosentase yang kamu daftarkan...")]
        public float Prosentase { get; set; }
        [Required(ErrorMessage = "{0} Gaji harus di isi.")]
        [Display(Name = "Gaji", Prompt = "Gaji yang kamu isi...")]
        public int Gaji { get; set; }
        public string Token { get; set; }
        //rolename adalah role pilihan yang akan di gunakan
        public string rolename { get; set; }
        //current role di masukan tempdata untuk mengetahui role lama dari user
        public string currentrole { get; set; }
        public string TenantID { get; set; }
        public string TenantName { get; set; }
        [Required(ErrorMessage = "{0} RwPenyakit harus di isi.")]
        [Display(Name = "RwPenyakit", Prompt = "RwPenyakit yang kamu isi...")]
        public string RwPenyakit { get; set; }
        [Required(ErrorMessage = "{0} Umur harus di isi.")]
        [Display(Name = "Umur", Prompt = "Umur yang kamu isi...")]
        public short Umur { get; set; }
        //for test using checkbox if i had 2 user or more....
        public bool Roleselect { get; set; }
        public bool IsEnabled { get; set; }
        [NotMapped]
        public DateTime Registrasi { get; set; }
        public DateTime TanggalJoin { get; set; }

    }
}
