using SDV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDV.Services
{
  public class ProductServices
  {
    private readonly List<Product> _products = new()
    {
      new Product { Id = 1, Name = "Coca-Cola 2L", Price = 9.99m },
      new Product { Id = 2, Name = "Arroz 5kg", Price = 27.50m },
      new Product { Id = 3, Name = "Feijão 1kg", Price = 8.30m },
      new Product { Id = 4, Name = "Molho de Tomate Quero 250g", Price = 5.99m },
      new Product { Id = 5, Name = "Margarina Qualy 500g", Price = 7.50m },
      new Product { Id = 6, Name = "Macarrão aliança", Price = 3.30m }
    };

    public void Add(Product product)
    {
      product.Id = _products.Count + 1;
      _products.Add(product);
    }

    public Product? FindById(long Id)
    {
      return _products.FirstOrDefault(p => p.Id == Id);
    }

    public List<Product> GetAll()
    {
      return _products;
    }
  }
}
