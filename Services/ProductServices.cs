using SDV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDV.Services
{
  public class ProductServices
  {
    private readonly Dictionary<long, Product> _byId = [];

    public ProductServices()
    {
      LoadFromDatabase();
    }

    public Product? FindById(long id)
    => _byId.GetValueOrDefault(id);

    private void LoadFromDatabase()
    {
      using var conn = Database.GetConnection();
      conn.Open();

      var cmd = conn.CreateCommand();
      cmd.CommandText =
      """
      SELECT Id, Name, Price
      FROM Products
      """;

      using var reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        var product = new Product
        {
          Id = reader.GetInt32(0),
          Name = reader.GetString(1),
          Price = reader.GetDecimal(2)
        };

        AddToCache(product);
      }
    }

    private void AddToCache(Product p)
    {
      _byId[p.Id] = p;
    }

    private void RemoveFromCache(long id)
    {
      if (!_byId.TryGetValue(id, out _))
        return;
      _byId.Remove(id);
    }

    public void Add(Product product)
    {
      using var conn = Database.GetConnection();
      conn.Open();

      var cmd = conn.CreateCommand();
      cmd.CommandText =
      """
      INSERT INTO Products (Id, Nome, Price)
      VALUES (@Id, @Name, @Price);
      SELECT last_insert_rowid();
      """;

      cmd.Parameters.AddWithValue("@Codigo", product.Id);
      cmd.Parameters.AddWithValue("@Name", product.Name);
      cmd.Parameters.AddWithValue("@Price", product.Price);

      product.Id = Convert.ToInt32(cmd.ExecuteScalar());

      AddToCache(product);
    }

    public void Update(Product product)
    {
      if (!_byId.ContainsKey(product.Id))
        throw new InvalidOperationException("Produto não existe");

      using var conn = Database.GetConnection();
      conn.Open();

      var cmd = conn.CreateCommand();
      cmd.CommandText =
      """
      UPDATE Products
      SET Codigo = @codigo,
          Nome = @nome,
          Preco = @preco
      WHERE Id = @id
      """;

      cmd.Parameters.AddWithValue("@Id", product.Id);
      cmd.Parameters.AddWithValue("@Name", product.Name);
      cmd.Parameters.AddWithValue("@Price", product.Price);

      cmd.ExecuteNonQuery();

      // Atualizar cache
      RemoveFromCache(product.Id);
      AddToCache(product);
    }

    public void Remove(int id)
    {
      if (!_byId.TryGetValue(id, out _))
        return;

      using var conn = Database.GetConnection();
      conn.Open();

      var cmd = conn.CreateCommand();
      cmd.CommandText =
      """
      DELETE FROM Products
      WHERE Id = @Id
      """;

      cmd.Parameters.AddWithValue("@Id", id);
      cmd.ExecuteNonQuery();

      RemoveFromCache(id);
    }
  }
}
