using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using EmployeeDirectoryWebApp.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EmployeeDirectoryWebApp.Controllers
{
    public class AccessController : Controller
    {
        private readonly EmployeeAppDbContext _dbContext;

        public AccessController(EmployeeAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            var user = _dbContext.UserAuthentications.Include(u => u.Role).FirstOrDefault(u => u.Username == modelLogin.Username && u.Password == modelLogin.PassWord);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    new Claim(ClaimTypes.Role, user.Role?.RoleName ?? "User") // Assuming default role is "User" if not specified
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }

            ViewData["ValidateMessage"] = "Invalid username or password.";
            return View();

           
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(VMSignup modelSignup)
        {
            if (ModelState.IsValid)
            {
                // Check if the user already exists
                var existingUser = await _dbContext.UserAuthentications.FirstOrDefaultAsync(u => u.Username == modelSignup.Username);

                if (existingUser != null)
                {
                    ModelState.AddModelError("Username", "Username already exists.");
                    return View(modelSignup);
                }

                // Create a new user
                var newUser = new UserAuthentication
                {
                    Username = modelSignup.Username,
                    Password = modelSignup.Password,
                    // Other properties
                };

                _dbContext.UserAuthentications.Add(newUser);
                await _dbContext.SaveChangesAsync();

                // Automatically log in the new user after signup
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, newUser.Username),
                    // You can add additional claims if needed
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            // If signup fails, return the signup view with validation errors
            return View(modelSignup);
        }
    }
}
