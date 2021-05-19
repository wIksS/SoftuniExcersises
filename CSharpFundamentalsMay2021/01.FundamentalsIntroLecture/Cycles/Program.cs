using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(i);
            //}
            int age;
            do
            {
                Console.WriteLine("(in while cycle)Enter your age: ");
                age = int.Parse(Console.ReadLine());
            } while (age < 0 || age > 122);

            Console.WriteLine($"you are {age} old");
        }
    }
}
