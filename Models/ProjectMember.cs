using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class ProjectMember
    {
        [Key]
        public int ProjectMemberID { get; set; } // Primary Key
        [ForeignKey("Projects")]

        public int ProjectID { get; set; } // FK to Projects
        [ForeignKey("Users")]
        public int UserID { get; set; } // FK to Users
    }
}
