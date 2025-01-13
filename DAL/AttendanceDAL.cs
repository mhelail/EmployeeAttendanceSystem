// DAL/AttendanceDAL.cs
using CalisanTakipAdvanced.Models;

using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using CalisanTakipAdvanced.DAL;

namespace CalisanTakipAdvanced.DAL
{
    public class AttendanceDAL
    {
        public List<AttendanceRecord> GetAllAttendance()
        {
            List<AttendanceRecord> list = new List<AttendanceRecord>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("GetAttendanceRecords", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttendanceRecord rec = new AttendanceRecord
                        {
                            AttendanceID = reader.GetInt32("AttendanceID"),
                            EmployeeID = reader.GetInt32("EmployeeID"),
                            CalisanAdi = reader.GetString("CalisanAdi"),
                            Date = reader.GetDateTime("Date"),
                            CheckInTime = reader.IsDBNull(reader.GetOrdinal("CheckInTime")) ? (TimeSpan?)null : reader.GetTimeSpan("CheckInTime"),
                            CheckOutTime = reader.IsDBNull(reader.GetOrdinal("CheckOutTime")) ? (TimeSpan?)null : reader.GetTimeSpan("CheckOutTime"),
                            Status = reader.GetString("Status")
                        };
                        list.Add(rec);
                    }
                }
            }
            return list;
        }

        public bool AddAttendance(AttendanceRecord record)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("AddAttendance", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empID", record.EmployeeID);
                cmd.Parameters.AddWithValue("@attDate", record.Date);
                cmd.Parameters.AddWithValue("@checkIn", record.CheckInTime.HasValue ? (object)record.CheckInTime.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@checkOut", record.CheckOutTime.HasValue ? (object)record.CheckOutTime.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@status", record.Status);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }

        public bool UpdateAttendance(AttendanceRecord record)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("UpdateAttendance", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@attID", record.AttendanceID);
                cmd.Parameters.AddWithValue("@empID", record.EmployeeID);
                cmd.Parameters.AddWithValue("@attDate", record.Date);
                cmd.Parameters.AddWithValue("@checkIn", record.CheckInTime.HasValue ? (object)record.CheckInTime.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@checkOut", record.CheckOutTime.HasValue ? (object)record.CheckOutTime.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@status", record.Status);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }

        public bool DeleteAttendance(int attendanceID)
        {
            bool result = false;

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand("DeleteAttendance", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@attID", attendanceID);

                conn.Open();
                result = (cmd.ExecuteNonQuery() > 0);
            }
            return result;
        }
    }
}
