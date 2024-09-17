using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationID { get; set; } // Primary Key
        [ForeignKey("Users")]
        public int UserID { get; set; } // FK to Users
        public string Message { get; set; }
        [Required]
        public bool ReadStatus { get; set; } // Read, Unread
        public DateTime NotificationDate { get; set; }
    }
}
