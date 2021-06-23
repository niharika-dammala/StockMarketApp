using StockMarket.ManageStockExchange.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ManageStockExchange.Api.Repositories
{
    public class StockExchangeRepository:IStockExchangeRepository
    {
        stockmarketdbContext db = new stockmarketdbContext();
        public void AddStockexchange(Stockexchange item)
        {
            db.Stockexchanges.Add(item);
            db.SaveChanges();
        }

        public Stockexchange GetStockexchangeDetails(int id)
        {
            Stockexchange se = db.Stockexchanges.SingleOrDefault(s => s.StockExchangeId == id);
            if (se != null)
            {
                return se;
            }
            else
            {
                return null;
            }
        }
        public List<Stockexchange> GetStockexchanges()
        {
            List<Stockexchange> se = new List<Stockexchange>();
            se = db.Stockexchanges.ToList();
            if (se != null)
            {
                return se;
            }
            else
            {
                return null;
            }
        }

        public List<Company> GetCompaniesInAStockExchange(string name)
        {
            var cmp2 = from m in db.Companies select m;



            cmp2 = db.Companies.Where(s => s.ListedStockExchange.Contains(name));



            return cmp2.ToList();
        }
    }
}
