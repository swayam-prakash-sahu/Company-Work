using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeDirectoryWebApplication.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeDirectoryWebApplication.Controllers
{
    [Authorize]
    public class ContactInformationsController : Controller
    {
        private readonly EmployeeAppDbContext _context;

        public ContactInformationsController(EmployeeAppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index1()
        {
            // Include related Employee data
            var contactInformations = await _context.ContactInformations
                .Include(c => c.Employee) // Include related Employee data
                .ToListAsync();

            return View(contactInformations);
        }

        // GET: ContactInformations
        public async Task<IActionResult> Index()
        {
            var contactList = await _context.ContactInformations
     .Join(
         _context.EmployeeProfiles,
         contact => contact.EmployeeId,
         profile => profile.EmployeeId,
         (contact, profile) => new ContactViewModel
         {
             OfficeLocation = contact.OfficeLocation,
             Phone = contact.Phone,
             Email = contact.Email,
             socialmediaprofile = contact.SocialMediaProfiles,
             EmployeeName = profile.EmployeeName,
             contactId=contact.ContactId
             
         }
     )
     .ToListAsync();

            return View(contactList);
        }

        // GET: ContactInformations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactInformation = await _context.ContactInformations
                .FirstOrDefaultAsync(m => m.ContactId == id);
            if (contactInformation == null)
            {
                return NotFound();
            }

            return View(contactInformation);
        }

        [Authorize(Roles = "Admin")]
        // GET: ContactInformations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactId,EmployeeId,Email,Phone,OfficeLocation,SocialMediaProfiles,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] ContactInformation contactInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactInformation);
        }

        [Authorize(Roles = "Admin")]
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
            return View(contactInformation);
        }

        // POST: ContactInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContactId,EmployeeId,Email,Phone,OfficeLocation,SocialMediaProfiles,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] ContactInformation contactInformation)
        {
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
            return View(contactInformation);
        }

        [Authorize(Roles = "Admin")]
        // GET: ContactInformations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactInformation = await _context.ContactInformations
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
