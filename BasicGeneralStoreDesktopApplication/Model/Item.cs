using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGeneralStoreDesktopApplication.Model
{
    public class Item
    {
        public String Name { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Quantity { get; set; }
        public String Unit { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
