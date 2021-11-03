using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            { 1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());

            List<char> stringList = list.Select((x,index) =>
            {
                Console.WriteLine("Selecting: " + x);
                Console.WriteLine("Index: " + index);
                return (char)x;
            })
                .ToList();

            //list = list.Select(x => 42).ToList();

            Console.WriteLine(string.Join(" ", stringList));
        }

        static char Plus10(int number, int index)
        {
            Console.WriteLine("Plus ten: " + number);
            return (char)(number + 10);
        }
    }
}
