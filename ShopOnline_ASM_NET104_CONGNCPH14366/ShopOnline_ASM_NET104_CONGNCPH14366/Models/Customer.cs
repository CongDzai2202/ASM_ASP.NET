using System;
using System.Collections.Generic;

#nullable disable

namespace ShopOnline_ASM_NET104_CONGNCPH14366.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Addresss { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? LocationId { get; set; }
        public int? Distric { get; set; }
        public int? Ward { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Pass { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? Active { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
