using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reflection
{
    public class Mouse
    {
        public int Id { get; set; }

        public int Precision { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine("Laptop is starting");
        }
    }
}
