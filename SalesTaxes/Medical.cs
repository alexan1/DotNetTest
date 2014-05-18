using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class Medical : Product
    {
        public override decimal GetPrice()
        {
            return 0.0m;
        }

        public override decimal GetSalesTax()
        {
            return 0.0m;

        }
        public override decimal GetTotal()
        {
            return 0.0m;
        }


    }
}
