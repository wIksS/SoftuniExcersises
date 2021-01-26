using System;

namespace Funcs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age now or then?");
            string input = Console.ReadLine();
            Func<int, DateTime, string> agePrinter = null;
            if (input == "now")
            {
                agePrinter = GetAge;
            }
            else if(input == "then")
            {
                agePrinter = GetAgeIn10Years;
            }

            Func<int, DateTime, string> agePrinterLamba =
                (age, date) => $"{age}годинки{date}";

            Console.WriteLine(agePrinter(5, DateTime.Now));
            Console.WriteLine(agePrinterLamba(23, DateTime.Now));
        }

        static string GetAge(int age, DateTime date)
        {
            return $"Your age is: {age} at {date}";
        }

        static string GetAgeIn10Years(int age, DateTime date)
        {
            return $"Your age is: {age + 10} at {date}";
        }
    }
}
