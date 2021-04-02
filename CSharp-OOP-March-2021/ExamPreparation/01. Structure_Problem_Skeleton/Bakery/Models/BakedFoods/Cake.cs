using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        public Cake(string name, decimal price) : base(name, 245, price)
        {
        }
    }
}
