using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace WpfApp1
{
    public class ShopService
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=baza_wpf;User Id=root;Password=root;";

        public List<Shop> GetShops()
        {
            List<Shop> shops = new List<Shop>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Shops";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        shops.Add(new Shop
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            RamSize = Convert.ToInt32(reader["RamSize"]),
                            DiscSize = Convert.ToInt32(reader["DiscSize"]),
                            OS = reader["OS"].ToString(),
                            Color = reader["Color"].ToString(),
                            Price = reader["Price"].ToString(),
                            YearOfProduction = Convert.ToInt32(reader["YearOfProduction"])
                        });
                    }
                }
            }
            return shops;
        }

        public void AddShop(Shop shop)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Shops (Name, Description, RamSize, DiscSize, OS, Color, Price, YearOfProduction) " +
                               "VALUES (@Name, @Description, @RamSize, @DiscSize, @OS, @Color, @Price, @YearOfProduction)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", shop.Name);
                command.Parameters.AddWithValue("@Description", shop.Description);
                command.Parameters.AddWithValue("@RamSize", shop.RamSize);
                command.Parameters.AddWithValue("@DiscSize", shop.DiscSize);
                command.Parameters.AddWithValue("@OS", shop.OS);
                command.Parameters.AddWithValue("@Color", shop.Color);
                command.Parameters.AddWithValue("@Price", shop.Price);
                command.Parameters.AddWithValue("@YearOfProduction", shop.YearOfProduction);
                command.ExecuteNonQuery();
            }
        }

        public void RemoveShop(int shopId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Shops WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", shopId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateShop(Shop shop)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Shops SET Name = @Name, Description = @Description, RamSize = @RamSize, " +
                               "DiscSize = @DiscSize, OS = @OS, Color = @Color, Price = @Price, " +
                               "YearOfProduction = @YearOfProduction WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", shop.Id);
                command.Parameters.AddWithValue("@Name", shop.Name);
                command.Parameters.AddWithValue("@Description", shop.Description);
                command.Parameters.AddWithValue("@RamSize", shop.RamSize);
                command.Parameters.AddWithValue("@DiscSize", shop.DiscSize);
                command.Parameters.AddWithValue("@OS", shop.OS);
                command.Parameters.AddWithValue("@Color", shop.Color);
                command.Parameters.AddWithValue("@Price", shop.Price);
                command.Parameters.AddWithValue("@YearOfProduction", shop.YearOfProduction);
                command.ExecuteNonQuery();
            }
        }
    }
}
