using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeClass;

namespace _07.Reflection
{
    public class Laptop : Product
    {

        public int Cores { get; set; }

        public string GPUModel { get; set; }

        public void Start()
        {
            Console.WriteLine("Laptop is starting");
        }
    }
}
