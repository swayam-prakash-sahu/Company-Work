using ASPDotNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext DbContext;

        public EmployeeController(EmployeeDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Employee> employees = DbContext.Employees.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }


        [Route("Employee/Get/{EmpId}")]
        public IActionResult Get(int Id)
        {
            List<Employee> employees = DbContext.Employees.Where(e => e.Id == Id).ToList();
            return View("Index", employees);
        }
    }
}
