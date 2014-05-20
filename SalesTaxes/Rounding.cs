using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class Rounding
    {
        public decimal roundTo { get; set; }

        public virtual decimal Round(decimal valToRound)
        {
            decimal remainder = Decimal.Remainder(valToRound, roundTo);
            if (remainder < (roundTo / 2))
                return valToRound - remainder;
            else
                return valToRound + (roundTo - remainder);
        }
    }
}
