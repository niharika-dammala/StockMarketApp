using System;
using System.Collections.Generic;

#nullable disable

namespace StockMarketApp.UploadExcel.Api.Models
{
    public partial class Sector
    {
        public Sector()
        {
            Companies = new HashSet<Company>();
        }

        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public string Brief { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
