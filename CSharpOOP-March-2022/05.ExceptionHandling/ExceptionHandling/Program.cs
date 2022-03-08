using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    count++;
                    if (count > 2)
                    {
                        break;
                    }
                    Console.WriteLine("Na kolko si??");
                    int n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Nevalidni godini!");
                    //throw exception;
                }
            }


            Console.WriteLine("After try catch");

        }
    }
}
