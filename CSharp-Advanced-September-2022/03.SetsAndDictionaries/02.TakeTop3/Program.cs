using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TakeTop3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = numbers
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(String.Join(" ",numbers));
            //int count = numbers.Count;
            //if (count > 3)
            //{
            //    count = 3;
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
        }
    }
}
