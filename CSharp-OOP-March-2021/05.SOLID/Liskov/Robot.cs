using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Robot : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eat robot");
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
