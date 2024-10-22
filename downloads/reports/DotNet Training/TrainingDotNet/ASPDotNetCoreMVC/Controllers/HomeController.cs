using ASPDotNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPDotNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext DbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(EmployeeDbContext dbContext, ILogger<HomeController> logger)
        {
            DbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(User user)
        {
            User? userfromDb = DbContext.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if (userfromDb != null)
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