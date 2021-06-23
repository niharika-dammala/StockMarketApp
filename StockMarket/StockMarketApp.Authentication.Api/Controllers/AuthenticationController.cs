
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
//using JWTMicroNetCore.Data;
//using JWTMicroNetCore.Models;
//using JWTMicroNetCore.Services;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using StockMarket.Auth.Api.Data;
//using StockMarket.Auth.Api.Models;
//using StockMarket.Auth.Api.Services;
using StockMarketApp.Authentication.Api.Models;
using StockMarketApp.Authentication.Api.Services;

namespace StockMarketApp.Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  //  [EnableCors("AllowOrigin")]
    public class AuthenticationController : ControllerBase
    {
        private readonly stockmarketdbContext _context;
        private readonly ITokenBuilder _tokenBuilder;

        public AuthenticationController(
            stockmarketdbContext context,
            ITokenBuilder tokenBuilder)
        {
            _context = context;
            _tokenBuilder = tokenBuilder;
        }
       // [Route("~/api/Login")]
        //[HttpPost("login")]
        [HttpGet("login")]
        [Route("~/api/Login/{uname}/{passwd}")]
        IActionResult Login(string uname, string passwd)
        {
            User use = _context.Users.SingleOrDefault(u => u.Username == uname && u.Password == passwd);
            //User u = service.Login(uname, passwd);
            
           
                return Ok(use);
            
            
        }
           // [Route("~/api/Login")]
        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] User user)
        //{
        //    var dbUser = await _context
        //        .Users
        //        .SingleOrDefaultAsync(u => u.Username == user.Username);

        //    if (dbUser == null)
        //    {
        //        return NotFound("User not found.");
        //    }

        //    // This is just an example, made for simplicity; do not store plain passwords in the database
        //    // Always hash and salt your passwords
        //    var isValid = dbUser.Password == user.Password;

        //    if (!isValid)
        //    {
        //        return BadRequest("Could not authenticate user.");
        //    }

        //     var token = _tokenBuilder.BuildToken(user.Username);

        //    return Ok(token);
        //}

        [HttpGet("verify")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> VerifyToken()
        {
            var username = User
                .Claims
                .SingleOrDefault();

            if (username == null)
            {
                return Unauthorized();
            }

            var userExists = await _context
                .Users
                .AnyAsync(u => u.Username == username.Value);

            if (!userExists)
            {
                return Unauthorized();
            }

            return NoContent();
        }
    }
}
