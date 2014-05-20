using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class Book : Product
    {
        public override decimal GetSalesTax()
        {
            return 0.0m;
        }
        public override decimal GetTotal()
        {
            return Price + GetSalesTax();
        }
    }
}
