using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // && -> true && true -> true
            // || -> true || false -> true
            int a = 5;
            int b = 10;
            bool and = a < b && a == 6;
            Console.WriteLine(and);

            Console.WriteLine($"{true || false} -> true");
            Console.WriteLine($"{false || true} -> true");
            Console.WriteLine($"{false || false} -> false");

            Console.WriteLine(!(5 == 5));
            Console.WriteLine(!false);
        }
    }
}
