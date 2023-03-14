using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeClass;

namespace _07.Reflection
{
    public class Mouse : Product
    {
        public int Precision { get; set; }

        public void Start()
        {
            Console.WriteLine("Laptop is starting");
        }
    }
}
