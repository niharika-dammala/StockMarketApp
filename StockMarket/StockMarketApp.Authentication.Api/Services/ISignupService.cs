//using StockMarket.Auth.Api.Models;
using StockMarketApp.Authentication.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.Authentication.Api.Services
{
    interface ISignupService
    {
        void AddUserAccount(User item);
        void EditUserAccount(User item);
    }
}
