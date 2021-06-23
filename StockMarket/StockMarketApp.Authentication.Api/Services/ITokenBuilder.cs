using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarketApp.Authentication.Api.Services
{
  public  interface ITokenBuilder
    {
      public  string BuildToken(string username);
    }
}
