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
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        public double Quantity { get; set; }
        public String Unit { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
