using System;
using System.Collections.Generic;

#nullable disable

namespace ShopOnline_ASM_NET104_CONGNCPH14366.Models
{
    public partial class TransactStatus
    {
        public TransactStatus()
        {
            Orders = new HashSet<Order>();
        }

        public int TransactStatusId { get; set; }
        public bool? Statuss { get; set; }
        public string Descriptions { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
