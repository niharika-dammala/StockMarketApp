using System;
using System.Collections.Generic;

#nullable disable

namespace StockMarket.ManageStockExchange.Api.Models
{
    public partial class Ipodetail
    {
        public int IpoId { get; set; }
        public string CompanyName { get; set; }
        public int StockExchangeId { get; set; }
        public int PricePerShare { get; set; }
        public int TotalNoOfShares { get; set; }
        public DateTime? OpenDate { get; set; }

        public virtual Stockexchange StockExchange { get; set; }
    }
}
