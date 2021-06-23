using StockMarket.ManageStockExchange.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ManageStockExchange.Api.Services
{
    interface IStockExchangeService
    {
        List<Stockexchange> GetStockexchanges();
        Stockexchange GetStockexchangeDetails(int id);
        void AddStockexchange(Stockexchange item);
        List<Company> GetCompaniesInAStockExchange(string name);
    }
}
