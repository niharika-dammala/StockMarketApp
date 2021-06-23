using StockMarketApp.ManageCompany.Api.Models;
using StockMarketApp.ManageCompany.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageCompany.Api.Services
{
    public class CompanyService: ICompanyService
    {
        private CompanyRepository _repo=new CompanyRepository();
        //public CompanyService(ICompanyRepository repository)
        //{
        //    _repo= (CompanyRepository)repository;
        //}
        public void AddCompany(Company item)
        {
            _repo.AddCompany(item);
        }
        public List<Company> GetCompanies()
        {
            return _repo.GetCompanies();
        }
        public List<Company> GetMatchingCompanies(string word)
        {
            return _repo.GetMatchingCompanies(word);
        }
        public List<Ipodetail> GetMatchingIpoDetails(string name)
        {
            return _repo.GetMatchingIpoDetails(name);
        }
        public void DeleteCompany(int id)
        {
            _repo.DeleteCompany(id);
        }

        public void EditCompany(Company item)
        {
            _repo.EditCompany(item);
        }
        public Company GetCompanyDetails(int id)
        {
            return _repo.GetCompanyDetails(id);
        }
        public Company GetCompanyDetailsByName(string name)
        {
            return _repo.GetCompanyDetailsByName(name);
        }
    }
}
