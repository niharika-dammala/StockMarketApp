using StockMarketApp.ManageCompany.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageCompany.Api.Services
{
    interface ICompanyService
    {
        Company GetCompanyDetailsByName(string name);
        List<Company> GetCompanies();
        List<Company> GetMatchingCompanies(string word);
        List<Ipodetail> GetMatchingIpoDetails(string name);
        public void AddCompany(Company item);
        Company GetCompanyDetails(int id);
        void EditCompany(Company item);
        void DeleteCompany(int id);
    }
}
