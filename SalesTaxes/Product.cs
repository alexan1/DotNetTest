using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class Product
    {   
        public string Name { get; set; }        
        public decimal Price { get; set; }        
        public bool IsImport { get; set; }
        public bool IsExempt { get; set; }
        
    }
}
