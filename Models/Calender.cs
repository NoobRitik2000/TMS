using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Calender
    {
        [Key]
        public int CalendarID { get; set; } // Primary Key
        [ForeignKey("Tasks")]
        public int TaskID { get; set; } // FK to Tasks
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
