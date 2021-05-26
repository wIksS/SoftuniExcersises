using System;

namespace IntegerOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.MaxValue;
            Console.WriteLine(number);

            number++;
            Console.WriteLine(number);

            //while (true)
            //{
            //    number*=2;
            //    Console.WriteLine(number);
            //}
        }
    }
}
