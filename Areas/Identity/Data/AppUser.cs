using System;


using Microsoft.AspNetCore.Identity;

namespace TMS.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    //[Required(ErrorMessage = "*required")]
    //public string Username { get; set; }

    //public string PhoneNumber { get; set; }
}

