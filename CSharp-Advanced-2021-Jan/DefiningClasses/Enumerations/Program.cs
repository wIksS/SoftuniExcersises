using System;

namespace Enumerations
{
    enum Day { Monday, Tuesday, Wednesday }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Size.S);
            Console.WriteLine((int)Size.M);
            Console.WriteLine((int)Size.L);
            Console.WriteLine((int)Size.XXL);

            SellShirt(0);

            //Console.WriteLine(DayOfWeek.);

        }

        public static void SellShirt(Size size)
        {
            Console.WriteLine("Selling shirt: " + size);
        }
    }
}
