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
    public class MovieCastsController : Controller
    {
        private readonly MoviesDatabaseContext _context;

        public MovieCastsController(MoviesDatabaseContext context)
        {
            _context = context;
        }

        // GET: MovieCasts
        public async Task<IActionResult> Index()
        {
            var moviesDatabaseContext = _context.MovieCasts.Include(m => m.Cast).Include(m => m.Movie);
            return View(await moviesDatabaseContext.ToListAsync());
        }

        // GET: MovieCasts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieCast = await _context.MovieCasts
                .Include(m => m.Cast)
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.MoviecastId == id);
            if (movieCast == null)
            {
                return NotFound();
            }

            return View(movieCast);
        }

        // GET: MovieCasts/Create
        public IActionResult Create()
        {
            ViewData["CastId"] = new SelectList(_context.Castcrews, "CastId", "CastId");
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId");
            return View();
        }

        // POST: MovieCasts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoviecastId,MovieId,CastId,Role,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] MovieCast movieCast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movieCast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CastId"] = new SelectList(_context.Castcrews, "CastId", "CastId", movieCast.CastId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", movieCast.MovieId);
            return View(movieCast);
        }

        // GET: MovieCasts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieCast = await _context.MovieCasts.FindAsync(id);
            if (movieCast == null)
            {
                return NotFound();
            }
            ViewData["CastId"] = new SelectList(_context.Castcrews, "CastId", "CastId", movieCast.CastId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", movieCast.MovieId);
            return View(movieCast);
        }

        // POST: MovieCasts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MoviecastId,MovieId,CastId,Role,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] MovieCast movieCast)
        {
            if (id != movieCast.MoviecastId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movieCast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieCastExists(movieCast.MoviecastId))
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
            ViewData["CastId"] = new SelectList(_context.Castcrews, "CastId", "CastId", movieCast.CastId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", movieCast.MovieId);
            return View(movieCast);
        }

        // GET: MovieCasts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieCast = await _context.MovieCasts
                .Include(m => m.Cast)
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(m => m.MoviecastId == id);
            if (movieCast == null)
            {
                return NotFound();
            }

            return View(movieCast);
        }

        // POST: MovieCasts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieCast = await _context.MovieCasts.FindAsync(id);
            if (movieCast != null)
            {
                _context.MovieCasts.Remove(movieCast);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieCastExists(int id)
        {
            return _context.MovieCasts.Any(e => e.MoviecastId == id);
        }
    }
}
