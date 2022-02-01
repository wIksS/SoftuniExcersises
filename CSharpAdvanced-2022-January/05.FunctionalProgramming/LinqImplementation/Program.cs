using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqImplementation
{
    class Program
    {
        static void StrangeFunc(int x,string y,object z, decimal xx)
        {
        }
        static void Main(string[] args)
        {
            Action<int, string, object, decimal> strangeFunction = StrangeFunc;
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //numbers = numbers.Where(x => x > 3).ToList();
            numbers = Where(numbers, IsBiggerThan3).ToList();
            Console.WriteLine(String.Join(",", numbers));
        }

        static bool IsBiggerThan3(int number)
        {
            return number > 3;
        }

        public static IEnumerable<int> Where(IEnumerable<int> list, Func<int, bool> checker)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (checker(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
