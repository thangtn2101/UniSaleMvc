﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UniSaleMvc.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Names { get; set; }
        public int? Price { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? CatId { get; set; }

        public virtual Category Cat { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
