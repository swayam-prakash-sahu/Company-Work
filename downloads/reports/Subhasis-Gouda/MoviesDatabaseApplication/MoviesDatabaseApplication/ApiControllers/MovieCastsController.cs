using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesDatabaseApplication.Models;

namespace MoviesDatabaseApplication.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCastsController : ControllerBase
    {
        private readonly MoviesDatabaseContext _context;

        public MovieCastsController(MoviesDatabaseContext context)
        {
            _context = context;
        }

        // GET: api/MovieCasts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieCast>>> GetMovieCasts()
        {
            return await _context.MovieCasts.ToListAsync();
        }

        // GET: api/MovieCasts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieCast>> GetMovieCast(int id)
        {
            var movieCast = await _context.MovieCasts.FindAsync(id);

            if (movieCast == null)
            {
                return NotFound();
            }

            return movieCast;
        }

        // PUT: api/MovieCasts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieCast(int id, MovieCast movieCast)
        {
            if (id != movieCast.MoviecastId)
            {
                return BadRequest();
            }

            _context.Entry(movieCast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieCastExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MovieCasts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieCast>> PostMovieCast(MovieCast movieCast)
        {
            _context.MovieCasts.Add(movieCast);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MovieCastExists(movieCast.MoviecastId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMovieCast", new { id = movieCast.MoviecastId }, movieCast);
        }

        // DELETE: api/MovieCasts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieCast(int id)
        {
            var movieCast = await _context.MovieCasts.FindAsync(id);
            if (movieCast == null)
            {
                return NotFound();
            }

            _context.MovieCasts.Remove(movieCast);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieCastExists(int id)
        {
            return _context.MovieCasts.Any(e => e.MoviecastId == id);
        }
    }
}
