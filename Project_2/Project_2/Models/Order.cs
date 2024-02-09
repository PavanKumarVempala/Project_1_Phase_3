using System;
using System.Collections.Generic;

namespace Project_2.Models
{
    public partial class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        public int Oid { get; set; }
        public DateTime? Odate { get; set; }
        public string? Oaddress { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
