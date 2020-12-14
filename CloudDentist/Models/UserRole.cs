using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class UserRole
    {
        [Key]
        public string roleID { get; set; }
        public string RoleName { get; set; }
        public string Username { get; set; }

    }
}
