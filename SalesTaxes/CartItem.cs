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
        public SalesTax Tax { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product item, SalesTax tax)
        {
            Item = item;
            Tax = tax;
        }        
        
        public decimal GetSalesTax()
        {
            return Item.GetSalesTax() + Tax.CalculateTax(Item.Price);
            
        }
        public decimal GetTotal()
        {
            return (Item.Price + GetSalesTax()) * Quantity;
        }
       
    }
}
