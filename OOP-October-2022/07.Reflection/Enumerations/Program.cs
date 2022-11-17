using System;

namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Days promotion = (Days)52;//Days.Wednesday | Days.Thursday | Days.Monday;

            Console.WriteLine(promotion);
            //Console.WriteLine(8 | 16);
            //Console.WriteLine(promotion);
            ////Console.WriteLine((int)promotion);
            //Console.WriteLine(promotion.HasFlag(Days.Wednesday));
            //Console.WriteLine(promotion.HasFlag(Days.Thursday));
            //Console.WriteLine(promotion.HasFlag(Days.Friday));
        }
    }

    [Flags]
    public enum Days
    {
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,          
        Friday = 32,
    }
}
