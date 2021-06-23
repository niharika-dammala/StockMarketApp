using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using StockMarket.AdminAPI.Models;
//using StockMarket.AdminAPI.Services;
using StockMarket.ManageStockExchange.Api.Models;
using StockMarket.ManageStockExchange.Api.Services;

namespace StockMarket.ManageStockExchange.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  //  [EnableCors("AllowOrigin")]
    public class StockpriceController : ControllerBase
    {
        StockpriceService service = new StockpriceService();
        stockmarketdbContext db = new stockmarketdbContext();
        [HttpGet]
        [Route("CheckMissingData/{cmpcode}/{*date:datetime}")]
        public IActionResult CheckMissingData(int cmpcode, DateTime date)
        {
            bool flag = service.CheckMissingData(cmpcode, date);
            if (flag)
            {
                return Ok("Data Available");
            }
            else
            {
                return Ok("Data Not Available");
            }
        }

        [HttpGet]
        [Route("GetStockpricesByName/{cmpcode}")]
        public IActionResult GetStockpricesByName(int cmpcode)
        {
            List<Stockprice> stockprices = new List<Stockprice>();
            stockprices = service.GetStockprices(cmpcode);
            if (stockprices != null)
            {
                return Ok(stockprices);
            }
            else
            {
                return NotFound("No Stocks");
            }
        }

        [HttpGet]
        [Route("GetStockprices")]
        public IActionResult GetStockprices()
        {
            List<Stockprice> stockprices = new List<Stockprice>();
            
            stockprices = db.Stockprices.ToList();
            if (stockprices != null)
            {
                return Ok(stockprices);
            }
            else
            {
                return NotFound("No Stocks");
            }
        }
       // cmp = db.Companies.ToList();
    }
}
