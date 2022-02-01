using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            CarState carState = (CarState)3;

            Console.WriteLine(carState);

            Console.WriteLine((CarState)2);

            Console.WriteLine((DayOfWeek)106);

            DateTime date = DateTime.Now;
            DayOfWeek dayOfWeek = date.DayOfWeek;
            DayOfWeek monday = DayOfWeek.Monday;
            Console.WriteLine(dayOfWeek);
        }
    }

    enum DayOfWeek
    {
        Monday = 55,
        Tuesday=444,
        Wednesday
    }
}
