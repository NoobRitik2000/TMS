using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Reports
    {
        [Key]
        
        public int ReportID { get; set; } // Primary Key
        [ForeignKey("Projects")]
        public int ProjectID { get; set; } // FK to Projects
        [ForeignKey("Users")]
        public int GeneratedBy { get; set; } // FK to Users
        public DateTime GeneratedDate { get; set; }
        public string ReportData { get; set; } // JSON or other format
    }
}
