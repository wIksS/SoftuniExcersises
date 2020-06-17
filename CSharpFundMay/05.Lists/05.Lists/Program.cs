using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(input.Length);
            List<string> listInput = Console.ReadLine().Split().ToList();
            Console.WriteLine(listInput.Count);

            List<int> numbers = new List<int>() { 1,2,3,4};

            numbers.Add(55);
            numbers.Add(65);
            numbers.Add(45);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers.Count);
            numbers.Add(45);
            Console.WriteLine(numbers.Count);


        }
    }
}
