using OpenClosed.Contracts;
using OpenClosed.Contracts.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What strategy do you want?");
            var strategyName = Console.ReadLine();

            var strategy = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => (typeof(ISortingStrategy).IsAssignableFrom(t))
                && typeof(ISortingStrategy) != t)
                .First(t => t.Name.StartsWith(strategyName));

            ISortingStrategy soringStrategy = (ISortingStrategy)Activator.CreateInstance(strategy);

            if (strategyName == "Merge")
            {
                soringStrategy = new MergeSorter();
            }
            if (strategyName == "Merge")
            {
                soringStrategy = new MergeSorter();
            }
            if (strategyName == "Merge")
            {
                soringStrategy = new MergeSorter();
            }

            Sorter sorter = new Sorter(soringStrategy);

            sorter.Sort(new List<int>());
        }
    }
}
