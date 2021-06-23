using StockMarket.ManageStockExchange.Api.Models;
using StockMarket.ManageStockExchange.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ManageStockExchange.Api.Services
{
    public class StockExchangeService:IStockExchangeService
    {
        StockExchangeRepository _repo = new StockExchangeRepository();

        public void AddStockexchange(Stockexchange item)
        {
            _repo.AddStockexchange(item);
        }

        public Stockexchange GetStockexchangeDetails(int id)
        {
            return _repo.GetStockexchangeDetails(id);
        }

        public List<Stockexchange> GetStockexchanges()
        {
            return _repo.GetStockexchanges();
        }
        public List<Company> GetCompaniesInAStockExchange(string name)
        {
            return _repo.GetCompaniesInAStockExchange(name);
        }
    }
}
