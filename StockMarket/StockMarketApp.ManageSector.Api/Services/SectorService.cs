using StockMarketApp.ManageSector.Api.Models;
using StockMarketApp.ManageSector.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageSector.Api.Services
{
    public class SectorService:ISectorService
    {
        private SectorRepository _repo = new SectorRepository();
        public List<Sector> GetSectors()
        {
            return _repo.GetSectors();
        }
        
        public Sector GetSectorDetails(int id)
        {
            return _repo.GetSectorDetails(id);
        }
        public List<Company> GetCompaniesInASector(int id)
        {
            return _repo.GetCompaniesInASector(id);
        }
    }
}
