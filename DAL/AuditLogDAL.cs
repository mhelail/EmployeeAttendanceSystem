using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;

using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CalisanTakipAdvanced.DAL
{
    public class AuditLogDAL
    {
        public bool InsertLog(int userID, string action)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("InsertAuditLog", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", userID);
                cmd.Parameters.AddWithValue("@action", action);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }

        public List<AuditLog> GetAllLogs()
        {
            List<AuditLog> logs = new List<AuditLog>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("GetAllAuditLogs", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AuditLog log = new AuditLog
                        {
                            LogID = reader.GetInt32("LogID"),
                            UserID = reader.GetInt32("UserID"),
                            Action = reader.GetString("Action"),
                            Timestamp = reader.GetDateTime("Timestamp")
                        };
                        logs.Add(log);
                    }
                }
            }
            return logs;
        }
    }
}
