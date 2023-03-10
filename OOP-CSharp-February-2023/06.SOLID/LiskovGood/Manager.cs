using LiskovGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstituonPrinciple
{
    class Manager : IWorker, ISleeper, ISalaryGetter
    {
        public void GetSalary()
        {
            Console.WriteLine("Thanks");
        }

        public void Sleep()
        {
            Console.WriteLine("WHen");
        }

        public void Work()
        {
            Console.WriteLine("Po malko i ot programista");
        }
    }
}
