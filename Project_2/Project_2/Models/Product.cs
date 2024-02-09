using System;
using System.Collections.Generic;

namespace Project_2.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string? Pname { get; set; }
        public double? Pprice { get; set; }
        public int? Oid { get; set; }

        public virtual Order? OidNavigation { get; set; }
    }
}
