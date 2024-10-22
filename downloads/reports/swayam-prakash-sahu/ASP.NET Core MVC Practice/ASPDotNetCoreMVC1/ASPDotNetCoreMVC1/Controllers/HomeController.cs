using ASPDotNetCoreMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPDotNetCoreMVC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string UserName, string Password)
        {
            if (UserName.ToLower() == "admin" && Password.ToLower() == "password")
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
