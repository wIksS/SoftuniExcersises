using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    public class Horse : IDrivable
    {
        public void Accelerate()
        {
            Console.WriteLine("Horse going faster");
        }

        public void Break()
        {
            Console.WriteLine("Horse going slower");
        }

        public void Start()
        {
            Console.WriteLine("Mounting horse");
        }
    }
}
