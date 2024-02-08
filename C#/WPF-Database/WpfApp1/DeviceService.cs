using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace WpfApp1
{
    public class DeviceService
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=baza_wpf;User Id=root;Password=root;";

        public List<Device> GetDevices()
        {
            List<Device> devices = new List<Device>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Devices";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        devices.Add(new Device
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            RamSize = Convert.ToInt32(reader["RamSize"]),
                            DiscSize = Convert.ToInt32(reader["DiscSize"]),
                            OS = reader["OS"].ToString(),
                            Broken = reader["Broken"].ToString()
                        });
                    }
                }
            }
            return devices;
        }

        public void AddDevice(Device device)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Devices (Name, Description, RamSize, DiscSize, OS, Broken) VALUES (@Name, @Description, @RamSize, @DiscSize, @OS, @Broken)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", device.Name);
                command.Parameters.AddWithValue("@Description", device.Description);
                command.Parameters.AddWithValue("@RamSize", device.RamSize);
                command.Parameters.AddWithValue("@DiscSize", device.DiscSize);
                command.Parameters.AddWithValue("@OS", device.OS);
                command.Parameters.AddWithValue("@Broken", device.Broken);
                command.ExecuteNonQuery();
            }
        }

        public void RemoveDevice(int deviceId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Devices WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", deviceId);
                command.ExecuteNonQuery();
            }
        }
    }
}
