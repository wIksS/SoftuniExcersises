using P02._Worker_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02._Worker_Before
{
    public class SeniorWorker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Works seniorly");
        }
    }
}
