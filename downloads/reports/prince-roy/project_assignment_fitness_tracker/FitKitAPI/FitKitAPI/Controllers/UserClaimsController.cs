using FitKitAPI.Data;
using FitKitAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitKitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserClaimsController : ControllerBase
    {
        private readonly FitKitDbContext _context;

        public UserClaimsController(FitKitDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UserDetails>>> Get()
        {
            var userIdStr = GetCurrentUser().UserId;
            if (Int32.TryParse(userIdStr, out int userIdInt))
            {
                var users = _context.UserDetails.FirstOrDefault(u => u.UserId == userIdInt);

                return users != null ? Ok(users) : NotFound();

            }
            else
            {
                return BadRequest("Invalid user ID format");
            }

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
    }
}
