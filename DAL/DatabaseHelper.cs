using MySql.Data.MySqlClient;
using System.Configuration;

namespace CalisanTakipAdvanced.DAL
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
