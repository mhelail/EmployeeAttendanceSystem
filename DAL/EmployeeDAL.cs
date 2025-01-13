using CalisanTakipAdvanced.DAL;
using CalisanTakipAdvanced.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CalisanTakipAdvanced.DAL
{
    public class EmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("GetAllEmployees", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            EmployeeID = reader.GetInt32("EmployeeID"),
                            Name = reader.GetString("Name"),
                            Position = reader.IsDBNull(reader.GetOrdinal("Position")) ? null : reader.GetString("Position"),
                            Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString("Phone"),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email"),
                            Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString("Address"),
                            HireDate = reader.GetDateTime("HireDate")
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }

        public bool AddEmployee(Employee emp)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("AddEmployee", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@position", emp.Position);
                cmd.Parameters.AddWithValue("@phone", emp.Phone);
                cmd.Parameters.AddWithValue("@email", emp.Email);
                cmd.Parameters.AddWithValue("@address", emp.Address);
                cmd.Parameters.AddWithValue("@hireDate", emp.HireDate);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }

        public bool UpdateEmployee(Employee emp)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("UpdateEmployee", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", emp.EmployeeID);
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@position", emp.Position);
                cmd.Parameters.AddWithValue("@phone", emp.Phone);
                cmd.Parameters.AddWithValue("@email", emp.Email);
                cmd.Parameters.AddWithValue("@address", emp.Address);
                cmd.Parameters.AddWithValue("@hireDate", emp.HireDate);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }

        public bool DeleteEmployee(int employeeID)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("DeleteEmployee", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", employeeID);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }
    }
}
