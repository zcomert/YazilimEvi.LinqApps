using System;
using System.Collections.Generic;

#nullable disable

namespace YazilimEvi.LinqApps.DAL
{
    public partial class SalesByCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
