using System;
using System.Collections.Generic;
using System.Text;

namespace SDV.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal BuyPrice { get; set; }
        public int Stock { get; set; }
    }
}
