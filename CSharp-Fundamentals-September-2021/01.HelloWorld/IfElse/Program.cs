using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = -5;

            if (age > 10)
            {
                Console.WriteLine("Watching Die hard");
            }
            else if (age > 0)
            {
                Console.WriteLine("Pinokio");
            }
            else if (age == 0)
            {
                Console.WriteLine("Age is 0");
            }
            else
            {
                Console.WriteLine("Invalid years");
            }
        }
    }
}
