using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class FactoryWorker : Worker
    {
        public FactoryWorker()
        {
            Console.WriteLine("In the factory worker constructor");
        }

        public FactoryWorker(string factoryCompany)
            :base(factoryCompany)
        {
            Console.WriteLine("In the factory worker constructor");
        }

        public void LeaveFactory()
        {
            Console.WriteLine(Gender);
            Console.WriteLine("Leave");
            Console.WriteLine(Name);
        }
    }
}
