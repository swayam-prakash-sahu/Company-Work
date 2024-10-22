//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using FitKitAPI.Data;
//using FitKitAPI.Models;

//namespace FitKitAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class WorkoutsController : ControllerBase
//    {
//        private readonly FitKitDbContext _context;

//        public WorkoutsController(FitKitDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Workouts
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Workout>>> GetWorkoutTable()
//        {
//            return await _context.WorkoutTable.ToListAsync();
//        }

//        // GET: api/Workouts/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Workout>> GetWorkout(int id)
//        {
//            var workout = await _context.WorkoutTable.FindAsync(id);

//            if (workout == null)
//            {
//                return NotFound();
//            }

//            return workout;
//        }

//        // PUT: api/Workouts/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutWorkout(int id, Workout workout)
//        {
//            if (id != workout.UserId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(workout).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!WorkoutExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Workouts
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<Workout>> PostWorkout(Workout workout)
//        {
//            _context.WorkoutTable.Add(workout);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetWorkout", new { id = workout.UserId }, workout);
//        }

//        // DELETE: api/Workouts/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteWorkout(int id)
//        {
//            var workout = await _context.WorkoutTable.FindAsync(id);
//            if (workout == null)
//            {
//                return NotFound();
//            }

//            _context.WorkoutTable.Remove(workout);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool WorkoutExists(int id)
//        {
//            return _context.WorkoutTable.Any(e => e.UserId == id);
//        }
//    }
//}
