using OpenClosedSortingStrategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedSortingStrategy
{
    public class Sorter
    {
        private ISortingStrategy sortingStrategy;

        public Sorter(string strategy)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(ISortingStrategy).IsAssignableFrom(t) && t.Name.StartsWith(strategy)).First();

            sortingStrategy = (ISortingStrategy)Activator.CreateInstance(type);
        }

        public List<T> Sort<T>(List<T> list)
        {
            //Sort
            list = sortingStrategy.Sort(list);
       
            return list;
        }
    }
}
