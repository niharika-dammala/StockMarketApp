using Microsoft.AspNetCore.Mvc;
using StockMarketApp.ManageCompany.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.ManageCompany.Api.Repositories
{
    public class CompanyRepository:ICompanyRepository
    {
        private readonly stockmarketdbContext db=new stockmarketdbContext();
        //public CompanyRepository(stockmarketdbContext context)
        //{
        //    db = context;
        //}
        public  void AddCompany(Company item)
        {
            db.Companies.Add(item);
             db.SaveChanges();
            //return Ok("Inserted successfully!");
        }
        public Company GetCompanyDetails(int id)
        {
            Company cmp = db.Companies.SingleOrDefault(s => s.CompanyCode == id);
            if (cmp != null)
            {
                return cmp;
            }
            else
            {
                return null;
            }
        }
        public Company GetCompanyDetailsByName(string name)
        {
            Company cmp = db.Companies.SingleOrDefault(s => s.CompanyName == name);
            if (cmp != null)
            {
                return cmp;
            }
            else
            {
                return null;
            }
        }
        public void EditCompany(Company item)
        {
            db.Companies.Update(item);
            db.SaveChanges();
        }
        public void DeleteCompany(int id)
        {
            Company cmp = db.Companies.Find(id);
            db.Companies.Remove(cmp);
            db.SaveChanges();
        }
        public List<Company> GetCompanies()
        {
            List<Company> cmp = new List<Company>();
            cmp = db.Companies.ToList();
            if (cmp != null)
            {
                return cmp;
            }
            else
            {
                return null;
            }
        }
        public List<Company> GetMatchingCompanies(string word)
        {
           // List<Company> cmp1 = new List<Company>();

             var cmp2 = from m in db.Companies select m;

                
                if (!String.IsNullOrEmpty(word))
                {
                    cmp2= db.Companies.Where(s => s.CompanyName.Contains(word));
                }
            
            
                return cmp2.ToList();
            //foreach(Company x in cmp2)
            //{

            //}
        }
        public List<Ipodetail> GetMatchingIpoDetails(string name)
        {
            // Company cmp1 = db.Companies.SingleOrDefault(s => s.CompanyName == name);
            //int id = cmp1.CompanyCode;

            List<Ipodetail> cmp2 = new List<Ipodetail>();
            List<Ipodetail> cmp = new List<Ipodetail>();

            cmp2 = db.Ipodetails.ToList();
            foreach(Ipodetail x in cmp2)
            {
                if (x.CompanyName == name)
                    cmp.Add(x);

            }
            if (cmp != null)
            {
                return cmp;
            }
            else
            {
                return null;
            }
        }
    }
}
