using System;

namespace _03.TimeAfter30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
                //24
                if (hours >= 24)
                {
                    hours = 0;
                }
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
