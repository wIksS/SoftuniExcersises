using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reflection
{
    public class Laptop
    {
        public int Id { get; set; }

        public int Cores { get; set; }

        public decimal Price { get; set; }

        public string GPUModel { get; set; }

        public void Start()
        {
            Console.WriteLine("Laptop is starting");
        }
    }
}
