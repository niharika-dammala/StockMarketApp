using System;
using System.Collections.Generic;

#nullable disable

namespace StockMarket.ManageStockExchange.Api.Models
{
    public partial class Stockprice
    {
        public int StockpriceId { get; set; }
        public int CompanyCode { get; set; }
        public int StockExchangeId { get; set; }
        public double CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public virtual Stockexchange StockExchange { get; set; }
    }
}
