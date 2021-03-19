using System;

namespace MultipleValueEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Tuesday | Days.Monday | Days.Wednesday | Days.Thursday;

            //Console.WriteLine((int)today);
            //Console.WriteLine(today);

            Console.WriteLine((Days)15);
        }
    }

    [Flags]
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8
    }
}
