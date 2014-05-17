using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class CartItem
    {        
        public Product Item { get; set; }
        public int Quantity { get; set; }

        public decimal GetPrice()
        {
            return 0.0m;
        }
        public decimal GetSalesTax()
        {
            return 0.0m;
        }
        public decimal GetTotal()
        {
            return 0.0m;
        }
       
    }
}
