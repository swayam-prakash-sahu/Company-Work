using BCrypt.Net;
using FitKitAPI.Data;
using FitKitAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FitKitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;

        private readonly FitKitDbContext _context;

        public LoginController(IConfiguration configuration, FitKitDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginDetails login)
        {
            var user = _context.UserCredential.FirstOrDefault(u => u.UserName.ToLower() == login.UserName.ToLower());

            if (user != null)
            {
                if (BCrypt.Net.BCrypt.EnhancedVerify(login.Password, user.Password, HashType.SHA512))
                {
                    var token = GenerateJwtToken(user);
                    return Ok(new { token });

                }
                else
                {
                    return BadRequest("Wrong password");
                }
            }

            return Unauthorized();

        }

        private string GenerateJwtToken(UserCredential user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Email, user.UserEmail),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName)
            };

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"], claims, expires: DateTime.Now.AddMinutes(20), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
