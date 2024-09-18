using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }  // Primary key as a string

        [Required]
        [StringLength(100)]
        public string ProjectName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string Priority { get; set; }

        [Required]
    
        public int CreatedBy { get; set; }
        //[ForeignKey("CreatedBy")]
        //public IdentityUser Creator { get; set; }  // Navigation property
        //[Required]
        public DateTime CreatedDate { get; set; }
    }
}
