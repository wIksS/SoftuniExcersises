using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Drinks
{
    public class Tea : Drink
    {
        public Tea(string name, int portion, string brand) : base(name, portion, 2.50m, brand)
        {
        }
    }
}
