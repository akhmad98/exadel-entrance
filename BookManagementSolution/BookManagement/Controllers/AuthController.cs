using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using BookManagement.DAL.Data;
using BookManagement.BLL;

namespace BookManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin user)
        {
            if (user.Username == "admin" && user.Password == "password")
            {
                var token = GenerateJwtToken(user.Username);
                return Ok(new { token });
            }
            return Unauthorized();
        }

        private string GenerateJwtToken(string username)
        {
            return "new Claim";
            // var claims = new[]
            // {
            //     new Claim(JwtRegisteredClaimNames.Sub, username),
            //     new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            // };

            // var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("549269609609f29ff9e07b18cca8772096b11cbf69feeb3eba5bb56407b0a260"));
            // var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // var token = new JwtSecurityToken(
            //     issuer: "yourdomain.com",
            // audience: "yourdomain.com",
            // claims: claims,
            // expires: DateTime.Now.AddMinutes(30),
            // signingCredentials: creds
            // );
            // return JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}