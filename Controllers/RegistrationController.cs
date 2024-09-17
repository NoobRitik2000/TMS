using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TMS.Areas.Identity.Data;

namespace TMS.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(TMSContext model)
        {
            if (ModelState.IsValid)
            {
                // Yahan pe aap data ko database me save kar sakte hain.
                // Model me sab kuch valid hone ke baad redirect ya success message dikha sakte hain.
                // Example ke liye:
                return RedirectToAction("Success");
            }

            // Agar validation error hai, wapas form ko render karo
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
}
}
