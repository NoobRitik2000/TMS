using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Files
    {
        [Key]
        public int FileID { get; set; } // Primary Key
        [ForeignKey("Tasks")]
        public int TaskID { get; set; } // FK to Tasks
        public string FilePath { get; set; }
        [ForeignKey("Users")]
        public int UploadedBy { get; set; } // FK to Users
        public DateTime UploadDate { get; set; }
    }
}
