//using StockMarket.Auth.Api.Data;
//using StockMarket.Auth.Api.Models;
using StockMarketApp.Authentication.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.Authentication.Api.Repositories
{
    public class SignupRepository
    {
        // private ApplicationDbContext db = new ApplicationDbContext();
        private readonly stockmarketdbContext db;

      /*  public SignupRepository()
        {
        }*/

        public SignupRepository(stockmarketdbContext context)
        {
            db = context;
        }
        public void AddUserAccount(User item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public void EditUserAccount(User item)
        {
            db.Users.Update(item);
            db.SaveChanges();
        }
    }
}
