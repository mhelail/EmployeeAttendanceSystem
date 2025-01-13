using CalisanTakipAdvanced.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace CalisanTakipAdvanced.DAL
{
    public class UserDAL
    {

        public User ValidateUser(string username, string password)
        {
            User foundUser = null;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("GetAllUsers", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Stored Procedure’de alias: Username -> KullaniciAdi, Password -> Sifre, Role -> Rol, UserID -> ID
                        string dbUsername = reader.GetString("KullaniciAdi");
                        string dbPassword = reader.GetString("Sifre");
                        string dbRole = reader.GetString("Rol");
                        int dbID = reader.GetInt32("ID");

                        // Basit kullanıcı adı + şifre karşılaştırması
                        if (dbUsername == username && dbPassword == password)
                        {
                            foundUser = new User
                            {
                                UserID = dbID,
                                Username = dbUsername,
                                Password = dbPassword,
                                Role = dbRole
                            };
                            break;
                        }
                    }
                }
            }

            return foundUser;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("GetAllUsers", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            UserID = reader.GetInt32("ID"),
                            Username = reader.GetString("KullaniciAdi"),
                            Password = reader.GetString("Sifre"),   // isterseniz ekleyebilirsiniz
                            Role = reader.GetString("Rol")
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public bool AddUser(User user)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("AddUser", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname", user.Username);
                cmd.Parameters.AddWithValue("@pwd", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }

        public bool UpdateUser(User user)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("UpdateUser", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", user.UserID);
                cmd.Parameters.AddWithValue("@uname", user.Username);
                cmd.Parameters.AddWithValue("@pwd", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }

            return result;
        }

        public bool DeleteUser(int userID)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("DeleteUser", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", userID);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }
    }
}
