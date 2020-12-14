﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDentist.Models
{
    public class TenantPengguna
    {
        public string TenantPenggunaID { get; set; }
        public string TenantID { get; set; }
        public string Username { get; set; }
        public bool StatusTenant { get; set; }
        public Tenant Tenant { get; set; }
        public Pengguna pengguna { get; set; }
    }
}
