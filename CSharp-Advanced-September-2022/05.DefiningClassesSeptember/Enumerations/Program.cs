using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPromotion((Day)int.Parse(Console.ReadLine()));
           
            //Console.WriteLine((int)Day.Monday);
            //Console.WriteLine((int)Day.Tuesday);
            //Console.WriteLine((int)Day.Wednesday);
            //Console.WriteLine((int)Day.Thursday);

            //GetPromotion(Day.Sunday);
        }

        static void GetPromotion(Day day)
        {
            if (day == Day.Sunday)
            {
                Console.WriteLine("Ima promociq");
            }
        }
    }

    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
}
