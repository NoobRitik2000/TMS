using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderID { get; set; } // Primary Key
        [ForeignKey("Tasks")]
        public int TaskID { get; set; } // FK to Tasks
        public DateTime ReminderTime { get; set; }
        [Required]
        public bool IsSent { get; set; } // If reminder is sent or not
        public DateTime SentDate { get; set; }
    }
}
