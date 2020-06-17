using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] { ",", " " },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //numbers.RemoveAll(current => current % 2 == 0 || current % 3 ==0);

            numbers.RemoveRange(1, 2);
            Console.WriteLine(String.Join(',', numbers));

        }
    }
}
