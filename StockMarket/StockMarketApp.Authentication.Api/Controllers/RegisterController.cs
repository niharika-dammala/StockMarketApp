using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StockMarketApp.Authentication.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SStockMarketApp.Authentication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [EnableCors("AllowOrigin")]
    public class RegisterController : ControllerBase
    {
      // private static readonly ApplicationDbContext db;
        private readonly stockmarketdbContext _context;
       
       
        public RegisterController(
            stockmarketdbContext context)
        {
            _context = context;
            
        }
      //  SignupService service = new SignupService(db);
        [Route("~/api/Signup")]
        [HttpPost("Signup")]
        public IActionResult Signup([FromBody] User user)
        {
           

                _context.Users.Add(user);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, user);
            
           
        }
        [HttpPut]
        [Route("EditUserAccount")]
        public IActionResult EditUserAccount(User item)
        {
            _context.Users.Update(item);
            _context.SaveChanges();
            return Ok();
        }

    }
}
