using System;
using System.Collections.Generic;

namespace AddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            List<int> list = new List<int>() { 5, 5 };

            list.AddRange(numbers);
            list.AddRange(numbers);
            list.AddRange(numbers);
            list.AddRange(numbers);

            Console.WriteLine(String.Join(",", list));
        }
    }
}
