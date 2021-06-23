using StockMarketApp.ManageSector.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageSector.Api.Repositories
{
    interface ISectorRepository
    {
        List<Sector> GetSectors();
        Sector GetSectorDetails(int id);
        List<Company> GetCompaniesInASector(int id);
    }
}
