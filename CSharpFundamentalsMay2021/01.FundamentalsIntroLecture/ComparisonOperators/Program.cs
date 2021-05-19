using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -5;
            Console.WriteLine(number == 5);
            Console.WriteLine(number == 6);
            Console.WriteLine(number < 3);
            Console.WriteLine(number > 3);
            Console.WriteLine(number >= 5); //<=
            Console.WriteLine(number != 5);

            bool isOdd = number == 5;

            Console.WriteLine(isOdd);
        }
    }
}
