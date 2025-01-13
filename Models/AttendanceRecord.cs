namespace CalisanTakipAdvanced.Models
{
    public class AttendanceRecord
    {
        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public string CalisanAdi { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan? CheckInTime { get; set; }
        public System.TimeSpan? CheckOutTime { get; set; }
        public string Status { get; set; }
    }
}
