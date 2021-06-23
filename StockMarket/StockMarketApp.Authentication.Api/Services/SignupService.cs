
using StockMarketApp.Authentication.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.Authentication.Api.Services
{
    public class SignupService:ISignupService
    {
       // static ApplicationDbContext db;
       // SignupRepository _repo = new SignupRepository();

        private readonly stockmarketdbContext db;
        public SignupService(stockmarketdbContext context)
        {
            db = context;
        }

        public void AddUserAccount(User item)
        { 
           // _repo.AddUserAccount(item);
            db.Users.Add(item);
            db.SaveChanges();
        }

        public void EditUserAccount(User item)
        {
           // _repo.EditUserAccount(item);
            db.Users.Update(item);
            db.SaveChanges();
        }
    }
}
