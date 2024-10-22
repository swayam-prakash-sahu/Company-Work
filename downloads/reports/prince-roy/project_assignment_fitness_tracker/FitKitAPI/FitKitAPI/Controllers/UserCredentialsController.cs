using BCrypt.Net;
using FitKitAPI.Data;
using FitKitAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FitKitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCredentialsController : ControllerBase
    {
        private readonly FitKitDbContext _context;

        public UserCredentialsController(FitKitDbContext context)
        {
            _context = context;
        }

        // GET: api/UserCredentials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserCredential>>> GetUserCredential()
        {
            return await _context.UserCredential.ToListAsync();
        }

        // GET: api/UserCredentials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserCredential>> GetUserCredential(int id)
        {
            var userCredential = await _context.UserCredential.FindAsync(id);

            if (userCredential == null)
            {
                return NotFound();
            }

            return userCredential;
        }

        // PUT: api/UserCredentials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserCredential(int id, UserCredential userCredential)
        {
            if (id != userCredential.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userCredential).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserCredentialExists(id))
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

        // POST: api/UserCredentials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserCredential>> PostUserCredential(UserCredential userCredential)
        {
            userCredential.FirstName = TitleCase(userCredential.FirstName);
            userCredential.LastName = TitleCase(userCredential.LastName);
            //userCredential.Active = true;

            // Hashing and salting
            var hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(userCredential.Password, HashType.SHA512);
            userCredential.Password = hashedPassword;

            _context.UserCredential.Add(userCredential);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserCredential", new { id = userCredential.UserId }, userCredential);
        }

        // DELETE: api/UserCredentials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserCredential(int id)
        {
            var userCredential = await _context.UserCredential.FindAsync(id);
            if (userCredential == null)
            {
                return NotFound();
            }

            _context.UserCredential.Remove(userCredential);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserCredentialExists(int id)
        {
            return _context.UserCredential.Any(e => e.UserId == id);
        }

        private UserClaimsModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new UserClaimsModel
                {
                    UserId = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value,
                    EmailAddress = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                    GivenName = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value,
                    Surname = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value,
                };
            }

            return null;
        }

        private static string TitleCase(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
        }
    }
}
