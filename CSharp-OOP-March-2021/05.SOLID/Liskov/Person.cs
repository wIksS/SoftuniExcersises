using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Person : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
