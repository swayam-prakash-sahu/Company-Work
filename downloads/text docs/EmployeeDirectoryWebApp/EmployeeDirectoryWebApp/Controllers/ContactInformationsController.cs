using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeDirectoryWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeDirectoryWebApp.Controllers
{

    [Authorize]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ContactInformationsController : Controller
    {
        private readonly EmployeeAppDbContext _context;

        public ContactInformationsController(EmployeeAppDbContext context)
        {
            _context = context;
        }

        // GET: ContactInformations
        public async Task<IActionResult> Index()
        {
            var employeeAppDbContext = _context.ContactInformations.Include(c => c.Employee);
            return View(await employeeAppDbContext.ToListAsync());
        }

        // GET: ContactInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactInformation = await _context.ContactInformations
                .Include(c => c.Employee)
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contactInformation == null)
            {
                return NotFound();
            }

            return View(contactInformation);
        }

        // GET: ContactInformations/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.EmployeeProfiles, "EmployeeId", "EmployeeId");
            return View();
        }

        // POST: ContactInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("ContactId,EmployeeId,Email,Phone,OfficeLocation,SocialMediaProfiles,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")]*/ ContactInformation contactInformation)
        {
            contactInformation.CreatedDate = DateTime.Now;
            contactInformation.CreatedBy = contactInformation.ContactId;
            contactInformation.UpdatedDate = DateTime.Now;
            contactInformation.UpdatedBy = contactInformation.ContactId;
            if (ModelState.IsValid)
            {
                _context.Add(contactInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.EmployeeProfiles, "EmployeeId", "EmployeeId", contactInformation.EmployeeId);
            return View(contactInformation);
        }

        // GET: ContactInformations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactInformation = await _context.ContactInformations.FindAsync(id);
            if (contactInformation == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.EmployeeProfiles, "EmployeeId", "EmployeeId", contactInformation.EmployeeId);
            return View(contactInformation);
        }

        // POST: ContactInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("ContactId,EmployeeId,Email,Phone,OfficeLocation,SocialMediaProfiles,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")]*/ ContactInformation contactInformation)
        {
            contactInformation.CreatedDate = DateTime.Now;
            contactInformation.CreatedBy = contactInformation.ContactId;
            contactInformation.UpdatedDate = DateTime.Now;
            contactInformation.UpdatedBy = contactInformation.ContactId;
            if (id != contactInformation.ContactId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactInformation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactInformationExists(contactInformation.ContactId))
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
            ViewData["EmployeeId"] = new SelectList(_context.EmployeeProfiles, "EmployeeId", "EmployeeId", contactInformation.EmployeeId);
            return View(contactInformation);
        }

        // GET: ContactInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactInformation = await _context.ContactInformations
                .Include(c => c.Employee)
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contactInformation == null)
            {
                return NotFound();
            }

            return View(contactInformation);
        }

        // POST: ContactInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactInformation = await _context.ContactInformations.FindAsync(id);
            if (contactInformation != null)
            {
                _context.ContactInformations.Remove(contactInformation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactInformationExists(int id)
        {
            return _context.ContactInformations.Any(e => e.ContactId == id);
        }
    }
}
