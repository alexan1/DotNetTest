using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class ImportDuty : SalesTax
    {
        public decimal Rate { get; set; }

        public ImportDuty()
        {
            Rate = 0.05m;
        }
    }
}
