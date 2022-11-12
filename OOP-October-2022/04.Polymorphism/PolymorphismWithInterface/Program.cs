using System;

namespace PolymorphismWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker worker = null;

            if (new Random().Next() % 2 == 0)
            {
                worker = new Programmer();
            }
            else
            {
                worker = new ProductManager();
            }

            Console.WriteLine(worker.GetType().Name);
            worker.Work();
        }

        interface IWorker
        {
            void Work();
        }

        class Programmer : IWorker
        {
            public int Seniority { get; set; }
            public void Work()
            {
                Console.WriteLine("Skatavam :) ");
            }
        }

        class ProductManager : IWorker
        {
            public int Imagination { get; set; }
            public void Work()
            {
                Console.WriteLine("Skatavam po malko :) ");
            }
        }
    }
}
