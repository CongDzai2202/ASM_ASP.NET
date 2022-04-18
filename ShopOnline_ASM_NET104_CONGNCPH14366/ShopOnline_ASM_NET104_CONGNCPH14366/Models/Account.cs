using System;
using System.Collections.Generic;

#nullable disable

namespace ShopOnline_ASM_NET104_CONGNCPH14366.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Salt { get; set; }
        public bool? Active { get; set; }
        public string FullName { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
