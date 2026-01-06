using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SDV.Models
{
  internal class CartItem
  {
    public long Id { get; set; }
    public string? Name { get; set; }
    public decimal Quantidade { get; set; }
    public decimal Price { get; set; }

    public decimal Total => Price * Quantidade;

    public CartItem() {
    }
  }
}
