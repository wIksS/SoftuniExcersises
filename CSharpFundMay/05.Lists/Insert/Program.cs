using System;
using System.Collections.Generic;
using System.Linq;

namespace Insert
{
    class Program
    {       
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Insert(2, 15555);
            numbers.Insert(0, 15555);
            numbers.Insert(55, 15555);

            Console.WriteLine(String.Join(',', numbers));

        }
    }
}
