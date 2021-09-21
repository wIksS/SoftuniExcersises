using System;

namespace ComparasionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            bool result = 5 < 10;
            Console.WriteLine(result);

            Console.WriteLine(a < b);
            Console.WriteLine(a > 0);
            Console.WriteLine(a > 100);
            Console.WriteLine(a < a);
            Console.WriteLine(a <= 5);
            Console.WriteLine(b == 2 * a);
        }
    }
}
