using Microsoft.AspNetCore.Mvc;

namespace clubrainbow.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            
            if (email == "clubrainbow@gmail.com" && password == "password")
            {
                
                return RedirectToAction("Msg", "VerifyMsg");
            }

            ViewBag.Message = "Invalid email or password.";
            return View();
        }
    }
}
