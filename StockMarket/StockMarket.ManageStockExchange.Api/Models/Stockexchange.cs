using System;
using System.Collections.Generic;

#nullable disable

namespace StockMarket.ManageStockExchange.Api.Models
{
    public partial class Stockexchange
    {
        public Stockexchange()
        {
            Ipodetails = new HashSet<Ipodetail>();
            Stockprices = new HashSet<Stockprice>();
        }

        public int StockExchangeId { get; set; }
        public string StockExchangeName { get; set; }
        public string Brief { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<Ipodetail> Ipodetails { get; set; }
        public virtual ICollection<Stockprice> Stockprices { get; set; }
    }
}
