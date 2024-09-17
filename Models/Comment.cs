using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; } // Primary Key
        [ForeignKey("Tasks")]
        public int TaskID { get; set; } // FK to Tasks
        public string CommentText { get; set; }
        [ForeignKey("Users")]
        public int CommentedBy { get; set; } // FK to Users
        public DateTime CommentDate { get; set; }
    }
}
