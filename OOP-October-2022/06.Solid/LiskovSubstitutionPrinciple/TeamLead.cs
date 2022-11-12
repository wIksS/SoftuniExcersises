using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    internal class TeamLead : IWorker, IEmployee
    {
        public void GetSalary()
        {
            Console.WriteLine("Getting the big salary");
        }

        public void Sleep()
        {
            Console.WriteLine("Getting the small sleep");
        }

        public void Work()
        {
            Console.WriteLine("Working the work");
        }
    }
}
