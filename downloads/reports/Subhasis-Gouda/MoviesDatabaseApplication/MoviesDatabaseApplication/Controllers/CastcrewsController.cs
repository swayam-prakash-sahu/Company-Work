using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesDatabaseApplication.Models;

namespace MoviesDatabaseApplication.Controllers
{
    [Authorize]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class CastcrewsController : Controller
    {
        private readonly MoviesDatabaseContext _context;

        public CastcrewsController(MoviesDatabaseContext context)
        {
            _context = context;
        }

        // GET: Castcrews
        public async Task<IActionResult> Index()
        {
            return View(await _context.Castcrews.ToListAsync());
        }

        // GET: Castcrews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var castcrew = await _context.Castcrews
                .FirstOrDefaultAsync(m => m.CastId == id);
            if (castcrew == null)
            {
                return NotFound();
            }

            return View(castcrew);
        }

        // GET: Castcrews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Castcrews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CastId,Name,Birthdate,Biography,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] Castcrew castcrew)
        {
            if (ModelState.IsValid)
            {
                _context.Add(castcrew);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(castcrew);
        }

        // GET: Castcrews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var castcrew = await _context.Castcrews.FindAsync(id);
            if (castcrew == null)
            {
                return NotFound();
            }
            return View(castcrew);
        }

        // POST: Castcrews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CastId,Name,Birthdate,Biography,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] Castcrew castcrew)
        {
            if (id != castcrew.CastId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(castcrew);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CastcrewExists(castcrew.CastId))
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
            return View(castcrew);
        }

        // GET: Castcrews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var castcrew = await _context.Castcrews
                .FirstOrDefaultAsync(m => m.CastId == id);
            if (castcrew == null)
            {
                return NotFound();
            }

            return View(castcrew);
        }

        // POST: Castcrews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var castcrew = await _context.Castcrews.FindAsync(id);
            if (castcrew != null)
            {
                _context.Castcrews.Remove(castcrew);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CastcrewExists(int id)
        {
            return _context.Castcrews.Any(e => e.CastId == id);
        }
    }
}
