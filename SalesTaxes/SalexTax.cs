using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class SalesTax
    {
        public decimal Rate { get; set; }
        public virtual decimal CalculateTax(decimal itemPrice)
        {
            decimal tempTax = itemPrice * this.Rate;
            decimal roundedTax = Rounding.Round(tempTax);
            return roundedTax;
        }
    }
}
