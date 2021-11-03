using System;
using System.Linq;

namespace _04.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray()));

        }
    }
}
