using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.ViewModel
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; }
        public string OldPassword { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "{0} harus di isi.")]
        [Display(Name = "ConfirmPassword", Prompt = "*******")]
        [Compare("Password", ErrorMessage = "Password Anda Tidak Sesuai !")]
        public string ConfirmPassword { get; set; }
        public int Status { get; set; }
    }
}
