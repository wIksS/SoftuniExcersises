using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Student
    {
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "1", "2" };
            arr.Select(ParseMethod);
            int[] nums = Console.ReadLine().Split().Select(ParseMethod).ToArray();
            Console.WriteLine(String.Join(",", nums));

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //numbers = numbers.Where(x => x > 3).ToList();
            //numbers = numbers.Select(Multiply).ToList();
            //numbers.OrderBy(x => x.Age);
            numbers = numbers.Where((int x123, int index123) =>
            {
                Console.WriteLine($"Checking {x123} > 3 index: {index123}");
                return x123 > 3;
            }).ToList();

            Console.WriteLine(String.Join(",", numbers));
        }
        public static int ReturnSame(int x)
        {
            return x;
        }

        public static int ParseMethod(string element)
        {
            return int.Parse(element);
        }

        public static int Multiply(int x)
        {
            return x * 5;
        }

        public static bool IsBiggerThan3(int x, int index)
        {
            Console.WriteLine($"Checking {x} > 3");
            return x > 3;
        }

        //public static bool IsBiggerThan3(int x)
        //{
        //    return x > 3;
        //}
    }
}
