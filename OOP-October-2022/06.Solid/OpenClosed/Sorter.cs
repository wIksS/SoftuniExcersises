using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OpenClosed
{
    internal class Sorter
    {
        private ISortingStrategy sortingStrategy;

        public Sorter(string strategyName)
        {    
            sortingStrategy = FindStrategy(strategyName);
        }

        public IEnumerable<int> Sort(IEnumerable<int> data)
        {
            if (sortingStrategy == null)
            {
                throw new ArgumentException("Sorting strategy is not valid.");
            }
            Console.WriteLine("Starting to sort");

            Console.ForegroundColor = ConsoleColor.Green;
            return sortingStrategy.Sort(data);
        }

        private ISortingStrategy FindStrategy(string strategyName)
        {
            Type type = Assembly.GetExecutingAssembly()
              .GetTypes().Where(t => typeof(ISortingStrategy).IsAssignableFrom(t) && t.Name.StartsWith(strategyName)).FirstOrDefault();

            return Activator.CreateInstance(type) as ISortingStrategy;
        }
    }
}
