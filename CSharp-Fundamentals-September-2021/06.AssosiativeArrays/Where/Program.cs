using System;
using System.Collections.Generic;
using System.Linq;

namespace Where
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = Enumerable.Range(0,100).ToList();

            int page = int.Parse(Console.ReadLine()) - 1;
            int count = 10;
            list = list
                //.Where(x => x % 2 ==0)
                .Skip(page * count)
                .Take(count)                
                .ToList();
            Console.WriteLine(string.Join(" ", list));
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
