using Microsoft.AspNetCore.Mvc;
using MoviesDatabaseApplication.Models;
using System;

namespace MoviesDatabaseApplication.Controllers
{
    public class SignupController : Controller
    {
        private readonly MoviesDatabaseContext _context;

        public SignupController(MoviesDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Signup model)
        {
            if (ModelState.IsValid)
            {
                var maxUserId = _context.Users.Max(u => (int?)u.UserId) ?? 0;
                var user = new User
                {
                    UserId = maxUserId+1,
                    UserName = model.UserName,
                    Password = model.Password,
                    Email = model.Email,
                    Phone = model.Phone,
                    IsActive = true,
                    RoleId = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = maxUserId+1
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}