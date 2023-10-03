using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using PhoneClass;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using MoreLinq;
using System.Data;

namespace PhoneAdministration
{

    public class PhoneDatabase
    {
        private string connectionString;
        private List<Phone> phones;
        public PhoneDatabase(string filepath)
        {
            // citire date db din fisier server, user, database, password
            string filePath = "C:\\Users\\Igor\\source\\repos\\POO-Phone app\\Config.txt";
            string[] lines = File.ReadAllLines(filePath);
            string server = lines[0];
            string database = lines[1];
            string username = lines[2];
            string password = lines[3];

            // connection string
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";


            
        }
        //metoda cautare telefoane dupa parametri oferiti
        public IEnumerable<Phone> Search(Func<Phone, bool> predicate)
        {
            foreach (Phone phone in phones)
            {
                if (predicate(phone))
                {
                    yield return phone;
                }
            }
        }
        //printare telefoane
        public void PrintPhones(IEnumerable<Phone> phones)
        {
            foreach (Phone phone in phones)
            {
                Console.WriteLine(phone);
            }
        }

      


       
        public List<Phone> ExtractPhoneData(string query,string query1)
        {
            List<Phone> phoneList = new List<Phone>();
            List<Phone> phoneList1 = new List<Phone>();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM phones WHERE " + query + " ORDER BY price", connection);
                //File.WriteAllText("C:\\Users\\Igor\\source\\repos\\POO-Phone app\\Query.txt", query1);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Phone phone = new Phone();
                        phone.Brand = reader.GetString("brand");
                        phone.Model = reader.GetString("model");
                        phone.Price = reader.GetDecimal("price");
                        phone.ScreenSize = reader.IsDBNull(reader.GetOrdinal("screen_size")) ? 0 : reader.GetDouble("screen_size");
                        phone.BatteryCapacity = reader.IsDBNull(reader.GetOrdinal("battery_capacity")) ? 0 : reader.GetInt32("battery_capacity");
                        phone.CameraQuality = reader.IsDBNull(reader.GetOrdinal("camera_quality")) ? 0 : reader.GetInt32("camera_quality");
                        phone.Sim = reader.IsDBNull(reader.GetOrdinal("sim")) ? "Unknown" : reader.GetString("sim");
                        phone.OS = reader.IsDBNull(reader.GetOrdinal("os")) ? "Unknown" : reader.GetString("os");
                        phone.color = reader.IsDBNull(reader.GetOrdinal("color")) ? "Unknown" : reader.GetString("color");
                        phone.Network = reader.IsDBNull(reader.GetOrdinal("retea")) ? 0 : reader.GetInt32("retea");
                        phone.year = reader.IsDBNull(reader.GetOrdinal("release_year")) ? 0 : reader.GetInt32("release_year");
                        phone.Cores = reader.IsDBNull(reader.GetOrdinal("nuclei")) ? 0 : reader.GetInt32("nuclei");
                        phone.StorageCapacity = reader.IsDBNull(reader.GetOrdinal("storage_capacity")) ? 0 : reader.GetInt32("storage_capacity");
                        phone.Ram = reader.IsDBNull(reader.GetOrdinal("ram")) ? 0 : reader.GetInt32("ram");
                        phone.Weight = reader.IsDBNull(reader.GetOrdinal("weight")) ? 0 : reader.GetDouble("weight");
                        phone.PhotoData = (byte[])reader["image"];
                        phoneList.Add(phone);
                    }
                }
                if(string.IsNullOrEmpty(query1))
                {
                    query1 = " and " + query1;
                }
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM phones WHERE brand IN ('Apple', 'Google') and " + query1, connection);

                using (MySqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Phone phone = new Phone();
                        phone.Brand = reader.GetString("brand");
                        phone.Model = reader.GetString("model");
                        phone.Price = reader.GetDecimal("price");
                        phone.ScreenSize = reader.IsDBNull(reader.GetOrdinal("screen_size")) ? 0 : reader.GetDouble("screen_size");
                        phone.BatteryCapacity = reader.IsDBNull(reader.GetOrdinal("battery_capacity")) ? 0 : reader.GetInt32("battery_capacity");
                        phone.CameraQuality = reader.IsDBNull(reader.GetOrdinal("camera_quality")) ? 0 : reader.GetInt32("camera_quality");
                        phone.Sim = reader.IsDBNull(reader.GetOrdinal("sim")) ? "Unknown" : reader.GetString("sim");
                        phone.OS = reader.IsDBNull(reader.GetOrdinal("os")) ? "Unknown" : reader.GetString("os");
                        phone.color = reader.IsDBNull(reader.GetOrdinal("color")) ? "Unknown" : reader.GetString("color");
                        phone.Network = reader.IsDBNull(reader.GetOrdinal("retea")) ? 0 : reader.GetInt32("retea");
                        phone.year = reader.IsDBNull(reader.GetOrdinal("release_year")) ? 0 : reader.GetInt32("release_year");
                        phone.Cores = reader.IsDBNull(reader.GetOrdinal("nuclei")) ? 0 : reader.GetInt32("nuclei");
                        phone.StorageCapacity = reader.IsDBNull(reader.GetOrdinal("storage_capacity")) ? 0 : reader.GetInt32("storage_capacity");
                        phone.Ram = reader.IsDBNull(reader.GetOrdinal("ram")) ? 0 : reader.GetInt32("ram");
                        phone.Weight = reader.IsDBNull(reader.GetOrdinal("weight")) ? 0 : reader.GetDouble("weight");
                        phone.PhotoData = (byte[])reader["image"];
                        bool exists = phoneList.Any(obj => obj.Brand == phone.Brand && obj.Model == phone.Model && obj.color == phone.color && obj.StorageCapacity == phone.StorageCapacity);

                        if (!exists)
                        {
                            // Adauga obiect nou la lista daca nu exista deja
                            phoneList.Add(phone);
                        }
                        //phoneList.Add(phone);
                    }
                }
            }

            //ordoneaza dupa pret
           
            phoneList = phoneList.OrderBy(p => p.Price).ToList();
            //sterge duplicatele
           

            return phoneList;
        }

    }
}