using StockMarketApp.ManageCompany.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageCompany.Api.Repositories
{
    interface ICompanyRepository
    {
        public Company GetCompanyDetailsByName(string name);
        List<Company> GetCompanies();
        List<Company> GetMatchingCompanies(string word);
        List<Ipodetail> GetMatchingIpoDetails(string name);
        Company GetCompanyDetails(int id);
        public  void AddCompany(Company item);
        void EditCompany(Company item);
        void DeleteCompany(int id);
    }
}
