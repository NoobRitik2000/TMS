using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Activities
    {
        [Key]
        public int ActivityID { get; set; } // Primary Key
        [ForeignKey("Projects")]
        public int ProjectID { get; set; } // FK to Projects
        [ForeignKey("Tasks")]
        public int TaskID { get; set; } // FK to Tasks
        public string ActivityDescription { get; set; }
        public int PerformedBy { get; set; } // FK to Users
        public DateTime PerformedDate { get; set; }
    }
}
