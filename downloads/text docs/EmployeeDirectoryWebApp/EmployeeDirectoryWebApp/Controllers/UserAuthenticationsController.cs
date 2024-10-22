using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeDirectoryWebApp.Models;

namespace EmployeeDirectoryWebApp.Controllers
{
    public class UserAuthenticationsController : Controller
    {
        private readonly EmployeeAppDbContext _context;

        public UserAuthenticationsController(EmployeeAppDbContext context)
        {
            _context = context;
        }

        // GET: UserAuthentications
        public async Task<IActionResult> Index()
        {
            var employeeAppDbContext = _context.UserAuthentications.Include(u => u.Role);
            return View(await employeeAppDbContext.ToListAsync());
        }

        // GET: UserAuthentications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAuthentication = await _context.UserAuthentications
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userAuthentication == null)
            {
                return NotFound();
            }

            return View(userAuthentication);
        }

        // GET: UserAuthentications/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId");
            return View();
        }

        // POST: UserAuthentications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Password,RoleId,IsActive,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] UserAuthentication userAuthentication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAuthentication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", userAuthentication.RoleId);
            return View(userAuthentication);
        }

        // GET: UserAuthentications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAuthentication = await _context.UserAuthentications.FindAsync(id);
            if (userAuthentication == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", userAuthentication.RoleId);
            return View(userAuthentication);
        }

        // POST: UserAuthentications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Password,RoleId,IsActive,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] UserAuthentication userAuthentication)
        {
            if (id != userAuthentication.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAuthentication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserAuthenticationExists(userAuthentication.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleId", userAuthentication.RoleId);
            return View(userAuthentication);
        }

        // GET: UserAuthentications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAuthentication = await _context.UserAuthentications
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userAuthentication == null)
            {
                return NotFound();
            }

            return View(userAuthentication);
        }

        // POST: UserAuthentications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userAuthentication = await _context.UserAuthentications.FindAsync(id);
            if (userAuthentication != null)
            {
                _context.UserAuthentications.Remove(userAuthentication);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserAuthenticationExists(int id)
        {
            return _context.UserAuthentications.Any(e => e.UserId == id);
        }
    }
}
