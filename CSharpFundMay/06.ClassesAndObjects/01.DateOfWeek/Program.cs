using System;
using System.Globalization;

namespace _01.DateOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy:H:mm:ss",
                CultureInfo.InvariantCulture);

            Console.WriteLine(date);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
