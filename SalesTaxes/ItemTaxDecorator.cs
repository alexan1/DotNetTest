using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public abstract class ItemTaxDecorator : CartItem
    {
        protected Product cartItem;
        protected SalesTax salesTax;

        public ItemTaxDecorator(Product item, SalesTax tax)
        {
            cartItem = item;
            salesTax = tax;
        }

        public virtual decimal GetSalesTax()
        {
            return cartItem.GetSalesTax() + salesTax.CalculateTax(cartItem.GetPrice());
        }

        public virtual decimal GetPrice()
        {
            return cartItem.GetPrice();
        }

        public virtual decimal GetTotal()
        {
            return this.GetPrice() + this.GetSalesTax();
        }

    }
}
