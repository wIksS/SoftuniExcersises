using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Shirt
    {
        //private string size;
        //private decimal price;
        //private int quantity;

        // Property (public data)
        public string Size { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        // Behaviour
        public void Wash()
        {
            Console.WriteLine("Tshirt was dirty now is clean :) MR proper");
        }
    }
}
