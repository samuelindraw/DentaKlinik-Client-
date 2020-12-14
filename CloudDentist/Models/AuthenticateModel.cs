using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class AuthenticateModel
    {

        [Required(ErrorMessage = "{0}  jangan lupa harus di isi")]
        [Display(Name = "Username", Prompt = "Username yang kamu daftarkan...")]
        public string Username { get; set; }
        [Required(ErrorMessage = "{0} harus di isi.")]
        [Display(Name = "Password", Prompt = "*******")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "{0} Email harus di isi.")]
        [Display(Name = "Email", Prompt = "Email yang kamu daftarkan...")]
        public string Email { get; set; }
        public string TenantID { get; set; }
        public Tenant Tenant { get; set; }
    }
}
