using System;

namespace MethodParams
{
    class Program
    {
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
            SayHello(name);
        }

        static void PrintSum(int a, int b)
        {
            SayHello("Print Sum method");
            Console.WriteLine($"The sum is: {a + b}");
        }

        static void Main(string[] args)
        {
            SayHello(Console.ReadLine());
            SayHello("Pinko");
            SayHello("");

            int a = 5;
            int b = 6;

            PrintSum(a, b);

            PrintSum(11, 12);
        }
    }
}
