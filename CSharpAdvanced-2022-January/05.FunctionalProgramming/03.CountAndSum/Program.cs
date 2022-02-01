using System;
using System.Linq;

namespace _03.CountAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);
            var numbers = Console.ReadLine().Split(", ").Select(parser).ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }

    }
}
