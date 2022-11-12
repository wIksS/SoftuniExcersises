using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    internal class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working the work");
        }
    }
}
