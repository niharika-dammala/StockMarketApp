//using StockMarket.AdminAPI.Models;
using StockMarket.ManageStockExchange.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ManageStockExchange.Api.Repositories
{
    interface IStockpriceRepository
    {
        bool CheckMissingData(int cmpcode, DateTime date);
        List<Stockprice> GetStockprices(int cmpcode);
    }
}
