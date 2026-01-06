using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.Sqlite;

public static class Database
{
  private const string ConnectionString = "Data Source=sdv.db";

  public static SqliteConnection GetConnection()
      => new(ConnectionString);

  public static void Initialize()
  {
    using var connection = GetConnection();
    connection.Open();

    var cmd = connection.CreateCommand();
    cmd.CommandText =
    """
    CREATE TABLE IF NOT EXISTS Products (
        Id INTEGER PRIMARY KEY,
        Name TEXT NOT NULL,
        Price REAL NOT NULL
    );
    """;

    cmd.ExecuteNonQuery();
  }
}

