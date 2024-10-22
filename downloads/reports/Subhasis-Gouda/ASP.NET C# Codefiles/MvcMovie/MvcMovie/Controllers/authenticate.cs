using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class authenticate : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult verify(string username,string password)
        {
            if (username.ToLower() == "admin" && password == "Hellow")
            {
                return RedirectToAction("index", "Movies");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
