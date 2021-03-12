using System;

namespace P02._Worker_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Worker());

            Manager manager2 = new Manager(new SeniorWorker());

        }
    }
}
