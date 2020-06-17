using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            //numbers.Sort();
            //numbers.Reverse();
            numbers =  numbers.OrderBy(item => item[item.Length-1]).ToList();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
