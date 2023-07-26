using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class TShirt : Product
    {
        public TShirt()
        {

        }
        public TShirt(string name, decimal price, int rating, string[] imageUrls)
    : base(name, price, rating, imageUrls)
        {
        }

        public string Size { get; set; }

        public string Fit { get; set; }

        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine($"TShirt: {Fit}, {Size}");
        }
    }
}
