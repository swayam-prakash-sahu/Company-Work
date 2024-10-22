using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreMVC.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Get(int empid)
        //{
        //    return View();
        //}
    }
}
