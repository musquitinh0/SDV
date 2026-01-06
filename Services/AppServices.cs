using System;
using System.Collections.Generic;
using System.Text;

namespace SDV.Services
{
  public static class AppServices
  {
    public static ProductServices? Products { get; private set; }

    public static void Initialize()
    {
      Products = new ProductServices();
    }
  }
}
