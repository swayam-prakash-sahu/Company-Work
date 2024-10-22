using FitKitAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitKitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckUsernameController : ControllerBase
    {
        private readonly FitKitDbContext _context;

        public CheckUsernameController(FitKitDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> CheckUsername([FromQuery] string username)
        {
            bool isTaken = await _context.UserCredential.AnyAsync(u => u.UserName == username);

            return Ok(new { exists = isTaken });
        }
    }
}
