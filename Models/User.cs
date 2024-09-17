//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;



//public class User
//{
//    [Key]
//    public int UserID { get; set; }  // Primary Key

//    [Required]
//    public string UserName { get; set; }

//    [Required]
//    [EmailAddress]
//    public string Email { get; set; }

//    [Phone]
//    public string PhoneNumber { get; set; }

//    [Required]
//    public string Password { get; set; }

//    //auto-generate
//    public DateTime CreatedDate { get; set; }

//    // Foreign Key for Role
//    [Required]
//    public int RoleID { get; set; }  // Foreign Key from Role table 
//}
