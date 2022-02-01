using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>{ 5 };
            Test(number);

            Console.WriteLine($"Number in main: {number[0]}");
        }

        public static void Test(List<int> number)
        {
            number[0]+= 10;
            Console.WriteLine($"Number in method: {number[0]}");
        }
    }
}
