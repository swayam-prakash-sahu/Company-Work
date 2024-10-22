using EmployeeDirectoryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeDirectoryWebApp.Controllers
{
    [Authorize]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeAppDbContext _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login()
        //{
            
           
        //        if (ModelState.IsValid)
        //        {
        //            var userdb = _context.UserAuthentications.Where(x => x.Username == Username && x.password == Password).FirstOrDefault();

        //            if (userdb != null)
        //            {
        //                return RedirectToAction("Index", "User");
        //            }
        //            else
        //            {
        //                ViewBag.message = "enter valid username and password";
        //                return View("Index");
        //            }
        //        }
        //        else
        //        {
        //            ViewBag.message = "enter valid username and password";
        //            return View("Index");
        //        }
        //    }

        //}

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }

    
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
