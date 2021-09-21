using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name");

            string name = Console.ReadLine();
            Console.WriteLine("What is your age");
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine("Your age in 10 years will be : " + (age + 10));
        }
    }
}
