using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StockMarketApp.ManageSector.Api.Models;
using StockMarketApp.ManageSector.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageSector.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  //  [EnableCors("AllowOrigin")]
    public class SectorController : Controller
    {
        private readonly ISectorService service = new SectorService();
        [HttpGet]
        [Route("GetSectors")]
        public IActionResult GetSectors()
        {
            List<Sector> cmp = new List<Sector>();
            cmp = service.GetSectors();
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("No Sector");
            }
        }
        [HttpGet]
        [Route("GetSectorDetails/{id}")]
        public IActionResult GetCompanyDetails(int id)
        {
            Sector cmp = service.GetSectorDetails(id);
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("Invalid Sector ID");
            }
        }
        [HttpGet]
        [Route("GetCompaniesInASector/{id}")]
        public IActionResult GetCompaniesInASector(int id)
        {
            List<Company> cmp = new List<Company>();
            cmp = service.GetCompaniesInASector(id);
            if (cmp != null)
            {
                return Ok(cmp);
            }
            else
            {
                return NotFound("Invalid Company Name");
            }
        }
    }
}
