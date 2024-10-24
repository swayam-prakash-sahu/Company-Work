﻿using ASPDotNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreMVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDbContext dbContext = new EmployeeDbContext();
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees;
            return View(employees);
        }

        [Route("Employee/Get/{EmpId}")]
        public IActionResult Get(int? EmpId)
        {
            List<Employee> employees = dbContext.Employees;
            return View("Index", employees);
        }
    }
}
