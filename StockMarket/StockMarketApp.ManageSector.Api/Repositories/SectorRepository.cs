using StockMarketApp.ManageSector.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageSector.Api.Repositories
{
    public class SectorRepository
    {
        private stockmarketdbContext db = new stockmarketdbContext();
        public List<Sector> GetSectors()
        {
            List<Sector> cmp = new List<Sector>();
            cmp = db.Sectors.ToList();
            if (cmp != null)
            {
                return cmp;
            }
            else
            {
                return null;
            }
        }

        public Sector GetSectorDetails(int id)
        {
            Sector cmp = db.Sectors.SingleOrDefault(s => s.SectorId == id);
            if (cmp != null)
            {
                return cmp;
            }
            else
            {
                return null;
            }
        }
       public List<Company> GetCompaniesInASector(int id)
        {
            var cmp2 = from m in db.Companies select m;


            
                cmp2 = db.Companies.Where(s => s.SectorId==id);
            


            return cmp2.ToList();
        }
    }
}
