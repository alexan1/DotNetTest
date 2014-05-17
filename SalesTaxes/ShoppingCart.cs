using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class ShoppingCart
    {
        public List<CartItem> ShoppingCartItems { get; set; }

        public void AddItem(CartItem item)
        {
            ShoppingCartItems.Add(item);
        }

        public decimal GetOrderPrice()
        {
            decimal total = 0.0M;
            foreach (var item in ShoppingCartItems)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public decimal GetOrderSalesTax()
        {
            decimal total = 0.0M;
            foreach (var item in ShoppingCartItems)
            {
                total += item.GetSalesTax();
            }
            return total;
        }

        public decimal GetOrderTotal()
        {
            return this.GetOrderPrice() + this.GetOrderSalesTax();
        }
    }
}
