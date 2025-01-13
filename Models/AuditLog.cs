namespace CalisanTakipAdvanced.Models
{
  
    
        public class AuditLog
        {
            public int LogID { get; set; }
            public int UserID { get; set; }
            public string Action { get; set; }
            public System.DateTime Timestamp { get; set; }
        }
    }

