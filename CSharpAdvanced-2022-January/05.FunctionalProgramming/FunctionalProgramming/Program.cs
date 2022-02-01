using System;

namespace FunctionalProgramming
{
    class Program
    {
        static int PromotionsCountToday = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(GetPromotion(100));

            PromotionsCountToday += 10;

            Console.WriteLine(GetPromotion(100));
            Console.WriteLine(GetPromotion(100));
            Console.WriteLine(GetPromotion(100));
        }

        // pure
        // side effect
        //public static decimal GetPromotion(10)
        //{
        //    Console.WriteLine("This is only called with 10");
        //}
        public static decimal GetPromotion(decimal price)
        {
            if (PromotionsCountToday < 3)
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                {
                    PromotionsCountToday++;
                    return price - price * 0.2m;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                {
                    PromotionsCountToday++;
                    return price - price * 0.2m;
                }
            }

            return price;
        }

    }
}
