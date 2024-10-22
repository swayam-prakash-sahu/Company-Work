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
//    public class NutritionsController : ControllerBase
//    {
//        private readonly FitKitDbContext _context;

//        public NutritionsController(FitKitDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Nutritions
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Nutrition>>> GetNutrition()
//        {
//            return await _context.Nutrition.ToListAsync();
//        }

//        // GET: api/Nutritions/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Nutrition>> GetNutrition(int id)
//        {
//            var nutrition = await _context.Nutrition.FindAsync(id);

//            if (nutrition == null)
//            {
//                return NotFound();
//            }

//            return nutrition;
//        }

//        // PUT: api/Nutritions/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutNutrition(int id, Nutrition nutrition)
//        {
//            if (id != nutrition.UserId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(nutrition).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!NutritionExists(id))
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

//        // POST: api/Nutritions
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<Nutrition>> PostNutrition(Nutrition nutrition)
//        {
//            _context.Nutrition.Add(nutrition);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetNutrition", new { id = nutrition.UserId }, nutrition);
//        }

//        // DELETE: api/Nutritions/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteNutrition(int id)
//        {
//            var nutrition = await _context.Nutrition.FindAsync(id);
//            if (nutrition == null)
//            {
//                return NotFound();
//            }

//            _context.Nutrition.Remove(nutrition);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool NutritionExists(int id)
//        {
//            return _context.Nutrition.Any(e => e.UserId == id);
//        }
//    }
//}
