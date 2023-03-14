using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationAttributes
{
    [Documentation("Product is a class that reprents a product")]
    internal class Product
    {

        [Documentation(Documentation ="PrintProduct is a method that prints the product. It is void and accepts 0 parameters")]
        public void PrintProduct()
        {

        }
    }
}
