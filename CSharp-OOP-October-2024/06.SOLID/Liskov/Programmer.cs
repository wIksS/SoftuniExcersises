using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Programmer : EmployedWorker ,IWorker
    {
        public override void GetPaid()
        {
            Console.WriteLine("Harchim vsichko");
        }

        public override void TakeBreak()
        {
            Console.WriteLine("nqma da se vryshtame");
        }

        public override void Work()
        {
            Console.WriteLine("Chakame pochivka");
        }
    }
}
