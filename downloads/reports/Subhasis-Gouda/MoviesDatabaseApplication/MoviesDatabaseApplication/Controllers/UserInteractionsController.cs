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
    public class UserInteractionsController : Controller
    {
        private readonly MoviesDatabaseContext _context;

        public UserInteractionsController(MoviesDatabaseContext context)
        {
            _context = context;
        }

        // GET: UserInteractions
        public async Task<IActionResult> Index()
        {
            var moviesDatabaseContext = _context.UserInteractions.Include(u => u.Movie).Include(u => u.User);
            return View(await moviesDatabaseContext.ToListAsync());
        }

        // GET: UserInteractions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInteraction = await _context.UserInteractions
                .Include(u => u.Movie)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.InteractId == id);
            if (userInteraction == null)
            {
                return NotFound();
            }

            return View(userInteraction);
        }

        // GET: UserInteractions/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: UserInteractions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,MovieId,Watchlist,Favorite,Views,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,InteractId")] UserInteraction userInteraction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInteraction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", userInteraction.MovieId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", userInteraction.UserId);
            return View(userInteraction);
        }

        // GET: UserInteractions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInteraction = await _context.UserInteractions.FindAsync(id);
            if (userInteraction == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", userInteraction.MovieId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", userInteraction.UserId);
            return View(userInteraction);
        }

        // POST: UserInteractions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,MovieId,Watchlist,Favorite,Views,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,InteractId")] UserInteraction userInteraction)
        {
            if (id != userInteraction.InteractId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInteraction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInteractionExists(userInteraction.InteractId))
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
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", userInteraction.MovieId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", userInteraction.UserId);
            return View(userInteraction);
        }

        // GET: UserInteractions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInteraction = await _context.UserInteractions
                .Include(u => u.Movie)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.InteractId == id);
            if (userInteraction == null)
            {
                return NotFound();
            }

            return View(userInteraction);
        }

        // POST: UserInteractions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userInteraction = await _context.UserInteractions.FindAsync(id);
            if (userInteraction != null)
            {
                _context.UserInteractions.Remove(userInteraction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserInteractionExists(int id)
        {
            return _context.UserInteractions.Any(e => e.InteractId == id);
        }
    }
}
