using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstituonPrinciple
{
    public class Programmer : IEmployee
    {
        public void GetSalary()
        {
            Console.WriteLine("Super");
        }

        public void Sleep()
        {
            Console.WriteLine("Mnogo spq");
        }

        public void Work()
        {
            Console.WriteLine("Ne mersi");
        }
    }
}
