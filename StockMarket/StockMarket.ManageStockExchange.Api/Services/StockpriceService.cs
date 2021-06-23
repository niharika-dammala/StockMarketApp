//using StockMarket.AdminAPI.Models;
//using StockMarket.AdminAPI.Repositories;
using StockMarket.ManageStockExchange.Api.Models;
using StockMarket.ManageStockExchange.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ManageStockExchange.Api.Services
{
    public class StockpriceService : IStockpriceService
    {
        StockpriceRepository _repo = new StockpriceRepository();
        public bool CheckMissingData(int cmpcode, DateTime date)
        {
            return _repo.CheckMissingData(cmpcode, date);
        }

        public List<Stockprice> GetStockprices(int cmpcode)
        {
            return _repo.GetStockprices(cmpcode);
        }
    }
}
