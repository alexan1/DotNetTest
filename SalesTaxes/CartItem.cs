using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class CartItem : Product
    {        
        public Product Item { get; set; }

        public CartItem(Product item)
        {
            Item = item;
        }
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
