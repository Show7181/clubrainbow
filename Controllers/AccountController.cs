using clubrainbow.Data;
using clubrainbow.Models;
using Microsoft.AspNetCore.Mvc;

namespace clubrainbow.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
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

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> AddAccount()
        {
            Console.WriteLine("AddAccount method is being called");


            var account = new Account
            {
                Username = "johnDoe",
                Email = "johndoe@example.com", 
                CreatedDate = DateTime.Now 
            };

            _context.Account.Add(account);

           
            await _context.SaveChangesAsync();

            return Ok("Account added successfully");
        }
    }
}
