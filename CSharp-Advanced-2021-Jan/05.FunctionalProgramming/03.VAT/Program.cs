using System;
using System.Linq;

namespace _03.VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(", ")
                .Select(Decimal.Parse)
                .Select(number => number + (number * 0.2m))
                .ToArray();

            //numbers = Select(numbers, number => number * 5);

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }

        static decimal[] Select(decimal[] array,Func<decimal, 
            decimal> transformer)
        {
            decimal[] newArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = transformer(array[i]);
            }

            return newArray;
        }
    }
}
