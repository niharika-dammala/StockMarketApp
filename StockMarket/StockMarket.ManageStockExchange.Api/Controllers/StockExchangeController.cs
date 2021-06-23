using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StockMarket.ManageStockExchange.Api.Models;
using StockMarket.ManageStockExchange.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ManageStockExchange.Api.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    //[EnableCors("AllowOrigin")]
    public class StockExchangeController : Controller
    {
        StockExchangeService service = new StockExchangeService();

        [HttpPost]
        [Route("AddStockexchange")]
        public IActionResult AddStockexchange(Stockexchange item)
        {
            service.AddStockexchange(item);
            return Ok();
        }

        [HttpGet]
        [Route("GetStockexchangeDetails/{id}")]
        public IActionResult GetStockexchangeDetails(int id)
        {
            Stockexchange se = service.GetStockexchangeDetails(id);
            if (se != null)
            {
                return Ok(se);
            }
            else
            {
                return NotFound("Invalid Stock Exchange");
            }
        }

        [HttpGet]
        [Route("GetStockexchanges")]
        public IActionResult GetStockexchanges()
        {
            List<Stockexchange> se = service.GetStockexchanges();
            if (se != null)
            {
                return Ok(se);
            }
            else
            {
                return NotFound("No Stock Exchange");
            }
        }
        [HttpGet]
        [Route("GetCompaniesInAStockExchange/{name}")]
        public IActionResult GetCompaniesInAStockExchange(string name)
        {
            List<Company> se = service.GetCompaniesInAStockExchange(name);
            if (se != null)
            {
                return Ok(se);
            }
            else
            {
                return NotFound("No Stock Exchange");
            }
        }
    }
}
