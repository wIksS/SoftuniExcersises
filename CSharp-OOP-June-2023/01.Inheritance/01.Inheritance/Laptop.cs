using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Inheritance
{
    public class Laptop : Product
    {
        public Laptop()
        {

        }
        public Laptop(string name, decimal price, int rating, string[] imageUrls)
            :base (name,price,rating,imageUrls)
        {
        }

        public LaptopCapacity Capacity{ get; set; }

        public string ScreenSize { get; set; }

        public override void PrintProduct()
        {
            base.PrintProduct();
            Console.WriteLine($"Laptop: {Capacity}, {ScreenSize}");
        }
    }
}
