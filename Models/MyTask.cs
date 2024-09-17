using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class MyTask
    {
        [Key]
        public int TaskID { get; set; } // Primary Key
        [ForeignKey("Projects")]
        public int ProjectID { get; set; } // FK to Projects
        [ForeignKey("Users")]
        public int AssignedTo { get; set; } // FK to Users
        [Required]
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        [Required]
        public string Status { get; set; } // Pending, InProcess, Done
        public string Priority { get; set; } // High, Medium, Low
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        // Navigation Properties
        //public User User { get; set; }  // Links to Assigned User
        //public Project Project { get; set; }  // Links to Project
    }
}
