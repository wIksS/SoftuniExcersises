using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Reverse().ToArray();

            strings[1] = "";

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
